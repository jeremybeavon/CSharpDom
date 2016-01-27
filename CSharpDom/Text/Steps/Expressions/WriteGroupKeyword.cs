namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteGroupKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("group");
        }
    }
}
