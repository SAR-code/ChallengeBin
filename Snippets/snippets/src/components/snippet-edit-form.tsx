"use client";
import type { Snippet } from "@prisma/client";

interface SnippetEditFormProps {
  snippet: Snippet;
}

//check

export default function SnippetEditForm({ snippet }: SnippetEditFormProps) {
  return <div>Client component has snippet title {snippet.title}</div>;
}
