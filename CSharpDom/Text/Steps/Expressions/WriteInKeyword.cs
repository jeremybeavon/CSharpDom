namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteInKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("in");
        }
    }
}
