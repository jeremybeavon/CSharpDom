namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteElseKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("else");
        }
    }
}
