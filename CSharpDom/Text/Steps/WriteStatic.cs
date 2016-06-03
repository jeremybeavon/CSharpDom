namespace CSharpDom.Text.Steps
{
    public sealed class WriteStatic : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(InheritanceModifierText.StaticText);
        }
    }
}
