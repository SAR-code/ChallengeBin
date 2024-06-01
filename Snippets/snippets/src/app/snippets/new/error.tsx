"use client";
// use client is mandatory

interface ErrorPageProps {
  error: Error;
  reset: () => void;
}

export default function ErrorPage({ error }: ErrorPageProps) {
  return <div>{error.message}</div>;
}
