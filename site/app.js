// Highlight plain-text examples without changing their copyable C# source.
const tokenPattern = /\/\/[^\n]*|"(?:\\.|[^"\\])*"|\b(?:using|var|new|stackalloc|bool|byte|int|long|float|ushort|ulong|string|false|true)\b|\b(?:System|Tedd|Span|ReadOnlySpan|ReadOnlyMemory|SpanStream|ReadOnlySpanStream|MemoryStreamer|Stream)\b|\b\d+(?:\.\d+)?(?:UL|L|f)?\b/g;

document.querySelectorAll("code[data-example]").forEach((code) => {
  const source = code.textContent;
  const fragment = document.createDocumentFragment();
  let offset = 0;
  for (const token of source.matchAll(tokenPattern)) {
    fragment.append(document.createTextNode(source.slice(offset, token.index)));
    const span = document.createElement("span");
    span.className = token[0].startsWith("//") ? "code-comment"
      : token[0].startsWith('"') ? "str"
      : /^\d/.test(token[0]) ? "num"
      : /^(System|Tedd|Span|ReadOnlySpan|ReadOnlyMemory|SpanStream|ReadOnlySpanStream|MemoryStreamer|Stream)$/.test(token[0]) ? "type" : "kw";
    span.textContent = token[0];
    fragment.append(span);
    offset = token.index + token[0].length;
  }
  fragment.append(document.createTextNode(source.slice(offset)));
  code.replaceChildren(fragment);
});

// Make horizontally scrollable source reachable using the keyboard.
document.querySelectorAll("pre").forEach((pre) => {
  pre.tabIndex = 0;
  pre.setAttribute("aria-label", "C# example; scroll horizontally if needed");
});

const copyButton = document.querySelector("[data-copy]");
const copyStatus = document.querySelector(".copy-status");

copyButton?.addEventListener("click", async () => {
  try {
    await navigator.clipboard.writeText(copyButton.dataset.copy);
    copyButton.textContent = "Copied";
    copyStatus.textContent = "Installation command copied to the clipboard.";
    window.setTimeout(() => {
      copyButton.textContent = "Copy";
      copyStatus.textContent = "";
    }, 2400);
  } catch {
    copyStatus.textContent = "Clipboard access was unavailable. Select and copy the command manually.";
  }
});
