namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteAwaitKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("await");
        }
    }
}
