namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteDoKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("do");
        }
    }
}
