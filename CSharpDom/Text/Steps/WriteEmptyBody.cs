namespace CSharpDom.Text.Steps
{
    public sealed class WriteEmptyBody : ISourceCodeBuilderStep
    {
        public WriteEmptyBody(string emptyBodyText = null)
        {
            EmptyBodyText = emptyBodyText;
        }

        public string EmptyBodyText { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            if (!string.IsNullOrWhiteSpace(EmptyBodyText))
            {
                builder.Append(EmptyBodyText);
            }
        }
    }
}
