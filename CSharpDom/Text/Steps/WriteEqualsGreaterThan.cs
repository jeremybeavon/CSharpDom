namespace CSharpDom.Text.Steps
{
    public sealed class WriteEqualsGreaterThan : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("=>");
        }
    }
}
