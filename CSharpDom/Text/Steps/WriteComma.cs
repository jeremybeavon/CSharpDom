namespace CSharpDom.Text.Steps
{
    public sealed class WriteComma : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(",");
        }
    }
}
