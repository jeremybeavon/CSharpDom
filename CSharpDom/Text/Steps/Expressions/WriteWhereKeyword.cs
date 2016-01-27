namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteWhereKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("where");
        }
    }
}
