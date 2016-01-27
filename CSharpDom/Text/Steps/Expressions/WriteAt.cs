namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteAt : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("@");
        }
    }
}
