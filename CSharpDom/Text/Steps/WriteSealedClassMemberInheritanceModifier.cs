namespace CSharpDom.Text.Steps
{
    public sealed class WriteSealedClassMemberInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteSealedClassMemberInheritanceModifier(SealedClassMemberInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public SealedClassMemberInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case SealedClassMemberInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
                case SealedClassMemberInheritanceModifier.Override:
                    builder.Append(InheritanceModifierText.OverrideText);
                    break;
                case SealedClassMemberInheritanceModifier.Static:
                    builder.Append(InheritanceModifierText.StaticText);
                    break;
            }
        }
    }
}
