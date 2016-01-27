namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteSwitchKeyword : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("switch");
        }
    }
}
