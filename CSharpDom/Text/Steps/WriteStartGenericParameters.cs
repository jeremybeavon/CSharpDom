using System;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteStartGenericParameters : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("<");
        }
    }
}
