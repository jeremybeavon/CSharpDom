namespace CSharpDom.Text.Steps
{
    public sealed class WriteEndParenthesis : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(")");
        }
    }
}
