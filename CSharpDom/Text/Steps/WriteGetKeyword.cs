namespace CSharpDom.Text.Steps
{
    public sealed class WriteGetKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("get");
        }
    }
}
