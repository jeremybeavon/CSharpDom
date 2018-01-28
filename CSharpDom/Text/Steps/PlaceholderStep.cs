namespace CSharpDom.Text.Steps
{
    public sealed class PlaceholderStep : ISourceCodeBuilderStep
    {
        public PlaceholderStep(SourceCodePlaceholder placeholder)
        {
            Placeholder = placeholder;
        }

        public SourceCodePlaceholder Placeholder { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
        }
    }
}
