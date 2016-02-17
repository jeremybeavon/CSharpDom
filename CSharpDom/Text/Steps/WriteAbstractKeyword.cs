namespace CSharpDom.Text.Steps
{
    public sealed class WriteAbstractKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("abstract");
        }
    }
}
