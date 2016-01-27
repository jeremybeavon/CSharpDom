namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteJoinKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("join");
        }
    }
}
