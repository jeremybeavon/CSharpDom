namespace CSharpDom.Text.Steps
{
    public sealed class WriteStructKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("struct");
        }
    }
}
