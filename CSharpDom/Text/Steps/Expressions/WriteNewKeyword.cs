namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteNewKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("new");
        }
    }
}
