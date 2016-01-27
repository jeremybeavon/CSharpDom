namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteSelectKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("select");
        }
    }
}
