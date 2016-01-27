namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteWhileKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("while");
        }
    }
}
