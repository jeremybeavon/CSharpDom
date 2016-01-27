namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteOrderByKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("orderby");
        }
    }
}
