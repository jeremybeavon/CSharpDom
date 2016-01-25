namespace CSharpDom.Text.Steps
{
    public sealed class WriteEnumKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("enum");
        }
    }
}
