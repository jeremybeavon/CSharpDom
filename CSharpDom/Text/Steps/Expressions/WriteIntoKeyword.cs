namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteIntoKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("into");
        }
    }
}
