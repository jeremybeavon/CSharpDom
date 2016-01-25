namespace CSharpDom.Text.Steps
{
    public sealed class WriteSemicolon : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(";");
        }
    }
}
