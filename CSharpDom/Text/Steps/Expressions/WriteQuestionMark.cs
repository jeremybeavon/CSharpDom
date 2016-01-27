namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteQuestionMark : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("?");
        }
    }
}
