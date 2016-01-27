namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteTryKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("try");
        }
    }
}
