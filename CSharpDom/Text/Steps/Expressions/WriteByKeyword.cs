namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteByKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("by");
        }
    }
}
