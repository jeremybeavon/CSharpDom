namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteOnKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("on");
        }
    }
}
