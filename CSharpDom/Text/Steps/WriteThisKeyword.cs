namespace CSharpDom.Text.Steps
{
    public sealed class WriteThisKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("this");
        }
    }
}
