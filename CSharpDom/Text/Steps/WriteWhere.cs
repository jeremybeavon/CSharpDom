namespace CSharpDom.Text.Steps
{
    public sealed class WriteWhere : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("where");
        }
    }
}
