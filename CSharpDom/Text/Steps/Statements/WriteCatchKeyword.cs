namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteCatchKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("catch");
        }
    }
}
