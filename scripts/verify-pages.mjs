import assert from "node:assert/strict";
import { readFileSync, existsSync } from "node:fs";
import { dirname, resolve } from "node:path";
import { fileURLToPath } from "node:url";

const root = resolve(dirname(fileURLToPath(import.meta.url)), "..");
const html = readFileSync(resolve(root, "site/index.html"), "utf8");
const ids = [...html.matchAll(/\bid="([^"]+)"/g)].map((match) => match[1]);
assert.equal(new Set(ids).size, ids.length, "Duplicate HTML identifiers");
for (const [, attribute, reference] of html.matchAll(/\b(href|src)="([^"]+)"/g)) {
  if (reference.startsWith("#")) {
    assert(ids.includes(reference.slice(1)), `Missing anchor: ${reference}`);
  } else if (!/^[a-z]+:/i.test(reference)) {
    assert(existsSync(resolve(root, "site", reference)), `Missing ${attribute}: ${reference}`);
  }
}

function parseCsvLine(line) {
  const fields = [];
  let value = "";
  let quoted = false;
  for (let index = 0; index < line.length; index++) {
    const character = line[index];
    if (character === '"') {
      if (quoted && line[index + 1] === '"') {
        value += '"';
        index++;
      } else {
        quoted = !quoted;
      }
    } else if (character === "," && !quoted) {
      fields.push(value);
      value = "";
    } else {
      value += character;
    }
  }
  assert(!quoted, "Unterminated CSV field");
  fields.push(value);
  return fields;
}

const utf8Source = readFileSync(resolve(root, "src/Tedd.SpanUtils.Benchmark/Utf8Benchmarks.cs"), "utf8");
const text = utf8Source.match(/private const string Text = "([^"]+)";/)?.[1];
const repetitions = Number(utf8Source.match(/Enumerable\.Repeat\(Text, (\d+)\)/)?.[1]);
assert(text && repetitions, "UTF-8 benchmark workload could not be read");
const textBytes = Buffer.byteLength(text.repeat(repetitions), "utf8");
const prefixBytes = textBytes <= 63 ? 1 : textBytes <= 16383 ? 2 : textBytes <= 4194303 ? 3 : 4;

const vlqInputs = [0n, 127n, 128n, 16384n, 4294967295n, 1n << 42n, 1n << 56n, 18446744073709551615n];
const vlqWidths = vlqInputs.map((value) => {
  let width = 1;
  while (value >= 128n) { value >>= 7n; width++; }
  return width;
});
const expectedBytes = {
  CurrentInt32LE: 4,
  CurrentInt64BE: 8,
  CurrentVLQ: vlqWidths.reduce((sum, value) => sum + value, 0) / vlqWidths.length,
  CurrentWrite: textBytes + prefixBytes,
  CurrentRead: textBytes + prefixBytes,
  CurrentMovingSpan: 8,
  CurrentSpanStream: 8,
  CurrentMemoryCopy: 1024,
};

const cases = [...html.matchAll(/<tr\s+data-benchmark="([^:"]+):([^"]+)"([^>]*)>([\s\S]*?)<\/tr>/g)];
assert.equal(cases.length, 10, "Expected ten measured workloads");
let valuesChecked = 0;
for (const [, suite, method, attributes, body] of cases) {
  const bytes = Number(attributes.match(/data-bytes="([^"]+)"/)?.[1]);
  const length = attributes.match(/data-length="([^"]+)"/)?.[1];
  assert.equal(bytes, method === "CurrentBulkReverse" ? Number(length) * 4 : expectedBytes[method], `${method}: incorrect byte count`);
  const runtimeCells = [...body.matchAll(/<td data-runtime="([^"]+)">([\d,]+)<\/td>/g)];
  assert.equal(runtimeCells.length, 2, `${method}: missing runtime measurement`);
  for (const [, runtime, displayed] of runtimeCells) {
    const csvPath = resolve(root, `docs/benchmarks/${runtime}/results/Tedd.Benchmarks.${suite}-report.csv`);
    const [headers, ...records] = readFileSync(csvPath, "utf8").trim().split(/\r?\n/).map(parseCsvLine);
    const rows = records.map((record) => Object.fromEntries(headers.map((header, index) => [header, record[index]])));
    const row = rows.find((candidate) => candidate.Method === method && (!length || candidate.Length === length));
    assert(row, `Missing source measurement: ${runtime}/${method}/${length ?? ""}`);
    assert(row.Mean.endsWith(" ns"), `Unexpected time unit: ${row.Mean}`);
    const meanNs = Number(row.Mean.replaceAll(",", "").replace(" ns", ""));
    assert(meanNs > 0, "Mean time must be positive");
    assert.equal(Number(displayed.replaceAll(",", "")), Math.round(bytes * 1000 / meanNs), `${runtime}/${method}: throughput does not match the source CSV`);
    valuesChecked++;
  }
}

const examples = [...html.matchAll(/<code data-example="([^"]+)">([\s\S]*?)<\/code>/g)];
assert.equal(examples.length, 7, "Expected seven C# examples");
assert(examples.every(([, , source]) => source.includes("using Tedd;")), "Examples must include the namespace");
console.log(`Pages verified: ${valuesChecked} throughput values, ${examples.length} examples, local assets and anchors.`);
