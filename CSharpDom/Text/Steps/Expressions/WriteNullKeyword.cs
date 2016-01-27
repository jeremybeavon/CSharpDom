namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteNullKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("null");
        }
    }
}
