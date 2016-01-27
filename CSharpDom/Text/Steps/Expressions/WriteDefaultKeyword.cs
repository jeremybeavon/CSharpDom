namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteDefaultKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("default");
        }
    }
}
