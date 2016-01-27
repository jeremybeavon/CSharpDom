namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteReturnKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("return");
        }
    }
}
