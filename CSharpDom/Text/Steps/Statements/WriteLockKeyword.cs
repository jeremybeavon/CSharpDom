namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteLockKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("lock");
        }
    }
}
