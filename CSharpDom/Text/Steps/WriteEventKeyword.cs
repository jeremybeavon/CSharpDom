namespace CSharpDom.Text.Steps
{
    public sealed class WriteEventKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("event");
        }
    }
}
