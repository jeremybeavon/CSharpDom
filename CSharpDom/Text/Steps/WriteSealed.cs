namespace CSharpDom.Text.Steps
{
    public sealed class WriteSealed : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(InheritanceModifierText.SealedText);
        }
    }
}
