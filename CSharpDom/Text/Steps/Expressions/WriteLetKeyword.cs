namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteLetKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("let");
        }
    }
}
