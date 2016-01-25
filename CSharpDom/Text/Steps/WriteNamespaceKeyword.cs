namespace CSharpDom.Text.Steps
{
    public sealed class WriteNamespaceKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("namespace");
        }
    }
}
