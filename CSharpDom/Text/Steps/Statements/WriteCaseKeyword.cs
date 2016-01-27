namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteCaseKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("case");
        }
    }
}
