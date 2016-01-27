namespace CSharpDom.Text.Steps
{
    public sealed class DecrementIndent : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Indent--;
        }
    }
}
