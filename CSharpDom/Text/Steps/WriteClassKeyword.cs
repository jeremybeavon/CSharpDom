namespace CSharpDom.Text.Steps
{
    public sealed class WriteClassKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("class");
        }
    }
}
