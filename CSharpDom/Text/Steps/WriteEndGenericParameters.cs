using System;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteEndGenericParameters : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("<");
        }
    }
}
