namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteTypeofKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("typeof");
        }
    }
}
