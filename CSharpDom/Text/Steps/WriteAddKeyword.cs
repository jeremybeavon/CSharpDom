namespace CSharpDom.Text.Steps
{
    public sealed class WriteAddKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("add");
        }
    }
}
