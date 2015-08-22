﻿using System;
using System.Linq;
using System.Text;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SourceCodeTextBuilder
    {
        private readonly StringBuilder textBuilder;
        private bool isFirstIndent;

        public SourceCodeTextBuilder()
        {
            textBuilder = new StringBuilder();
            IndentText = string.Empty.PadLeft(4);
            isFirstIndent = true;
        }

        public string IndentText { get; set; }

        public int Indent { get; set; }

        public void Append(string text)
        {
            textBuilder.Append(text);
        }

        public void AppendIndent()
        {
            if (isFirstIndent)
            {
                isFirstIndent = false;
                return;
            }

            textBuilder.AppendLine();
            foreach (string indent in Enumerable.Repeat(IndentText, Indent))
            {
                textBuilder.Append(indent);
            }
        }

        public void AppendWithIndent(string text)
        {
            AppendIndent();
            Append(text);
        }

        public IDisposable IncrementIndent()
        {
            Indent++;
            return new DisposableIndent(this);
        }

        public override string ToString()
        {
            return textBuilder.ToString();
        }

        private sealed class DisposableIndent : IDisposable
        {
            private readonly SourceCodeTextBuilder textBuilder;

            public DisposableIndent(SourceCodeTextBuilder textBuilder)
            {
                this.textBuilder = textBuilder;
            }

            public void Dispose()
            {
                textBuilder.Indent--;
            }
        }
    }
}
