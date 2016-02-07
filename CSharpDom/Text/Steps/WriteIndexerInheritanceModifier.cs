namespace CSharpDom.Text.Steps
{
    public sealed class WriteIndexerInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteIndexerInheritanceModifier(IndexerInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public IndexerInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case IndexerInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
                case IndexerInheritanceModifier.Override:
                    builder.Append(InheritanceModifierText.OverrideText);
                    break;
                case IndexerInheritanceModifier.Virtual:
                    builder.Append(InheritanceModifierText.VirtualText);
                    break;
            }
        }
    }
}
