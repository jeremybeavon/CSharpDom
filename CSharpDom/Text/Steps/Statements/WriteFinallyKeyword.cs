namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteFinallyKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("finally");
        }
    }
}
