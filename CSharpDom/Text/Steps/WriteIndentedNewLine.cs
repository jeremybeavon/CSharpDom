namespace CSharpDom.Text.Steps
{
    public sealed class WriteIndentedNewLine : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.AppendIndent();
        }
    }
}
