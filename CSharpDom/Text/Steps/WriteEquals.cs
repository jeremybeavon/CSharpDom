namespace CSharpDom.Text.Steps
{
    public sealed class WriteEquals : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("=");
        }
    }
}
