namespace CSharpDom.Text.Steps
{
    public sealed class WriteWhitespace : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(" ");
        }
    }
}
