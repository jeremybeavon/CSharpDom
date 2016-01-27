namespace CSharpDom.Text.Steps
{
    public sealed class WriteDelegateKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("delegate");
        }
    }
}
