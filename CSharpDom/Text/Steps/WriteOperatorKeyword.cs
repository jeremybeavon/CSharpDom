namespace CSharpDom.Text.Steps
{
    public sealed class WriteOperatorKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("operator");
        }
    }
}
