namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteContinueKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("continue");
        }
    }
}
