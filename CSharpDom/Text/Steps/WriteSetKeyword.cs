namespace CSharpDom.Text.Steps
{
    public sealed class WriteSetKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("set");
        }
    }
}
