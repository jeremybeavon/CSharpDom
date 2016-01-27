namespace CSharpDom.Text.Steps
{
    public sealed class WriteEndBracket : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("]");
        }
    }
}
