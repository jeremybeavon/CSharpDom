namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteFromKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("from");
        }
    }
}
