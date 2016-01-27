namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteEqualsKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("equals");
        }
    }
}
