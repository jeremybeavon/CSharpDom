using System;

namespace CSharpDom.Text.Steps
{
    public sealed class IncrementIndent : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Indent++;
        }
    }
}
