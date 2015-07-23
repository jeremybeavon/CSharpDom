using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SourceCodeTextBuilder
    {
        private readonly StringBuilder textBuilder;

        public SourceCodeTextBuilder()
        {
            textBuilder = new StringBuilder();
            IndentText = string.Empty.PadLeft(4);
        }

        public string IndentText { get; set; }

        public int Indent { get; set; }

        public void Append(string text)
        {
            textBuilder.Append(text);
        }

        public void AppendIndent()
        {
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
