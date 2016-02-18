namespace CSharpDom.Text.Steps
{
    public sealed class WriteConstantKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("const");
        }
    }
}
