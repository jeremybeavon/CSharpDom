namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteInKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("in");
        }
    }
}
