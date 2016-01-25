namespace CSharpDom.Text.Steps
{
    public sealed class WriteInterfaceKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("interface");
        }
    }
}
