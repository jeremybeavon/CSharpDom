namespace CSharpDom.Text.Steps
{
    public sealed class WriteAsyncKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("async");
        }
    }
}
