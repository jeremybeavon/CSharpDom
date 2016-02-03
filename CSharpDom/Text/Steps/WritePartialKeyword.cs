namespace CSharpDom.Text.Steps
{
    public sealed class WritePartialKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("partial");
        }
    }
}
