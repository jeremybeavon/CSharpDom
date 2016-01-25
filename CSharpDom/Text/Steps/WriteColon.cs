namespace CSharpDom.Text.Steps
{
    public sealed class WriteColon : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(":");
        }
    }
}
