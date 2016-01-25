namespace CSharpDom.Text.Steps
{
    public sealed class WriteRawValue : ISourceCodeBuilderStep
    {
        public WriteRawValue(string rawValue)
        {
            RawValue = rawValue;
        }

        public string RawValue { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(RawValue);
        }
    }
}
