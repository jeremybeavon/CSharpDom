namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteForKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("for");
        }
    }
}
