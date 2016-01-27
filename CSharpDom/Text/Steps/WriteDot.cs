namespace CSharpDom.Text.Steps
{
    public sealed class WriteDot : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(".");
        }
    }
}
