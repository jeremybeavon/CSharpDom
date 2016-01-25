using System;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteNewLine : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.AppendLine();
        }
    }
}
