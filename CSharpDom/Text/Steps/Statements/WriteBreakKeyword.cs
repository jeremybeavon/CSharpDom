namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteBreakKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("break");
        }
    }
}
