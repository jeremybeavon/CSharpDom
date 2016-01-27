namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteForeachKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("foreach");
        }
    }
}
