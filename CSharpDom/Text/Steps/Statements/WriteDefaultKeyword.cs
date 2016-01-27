namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteDefaultKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("default");
        }
    }
}
