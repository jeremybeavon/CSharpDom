namespace CSharpDom.Text.Steps
{
    public sealed class WriteSealedClassIndexerInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteSealedClassIndexerInheritanceModifier(SealedClassIndexerInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public SealedClassIndexerInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case SealedClassIndexerInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
                case SealedClassIndexerInheritanceModifier.Override:
                    builder.Append(InheritanceModifierText.OverrideText);
                    break;
            }
        }
    }
}
