namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteGotoKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("goto");
        }
    }
}
