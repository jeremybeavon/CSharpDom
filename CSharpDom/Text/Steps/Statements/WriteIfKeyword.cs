namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteIfKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("if");
        }
    }
}
