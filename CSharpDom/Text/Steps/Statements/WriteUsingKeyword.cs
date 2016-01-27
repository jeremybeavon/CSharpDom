namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteUsingKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("using");
        }
    }
}
