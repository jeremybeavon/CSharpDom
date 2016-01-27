namespace CSharpDom.Text.Steps
{
    public sealed class WriteStartParenthesis : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("(");
        }
    }
}
