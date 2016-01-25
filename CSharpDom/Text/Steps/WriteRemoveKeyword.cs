namespace CSharpDom.Text.Steps
{
    public sealed class WriteRemoveKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("remove");
        }
    }
}
