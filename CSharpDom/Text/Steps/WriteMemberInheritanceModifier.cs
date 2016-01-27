namespace CSharpDom.Text.Steps
{
    public sealed class WriteMemberInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteMemberInheritanceModifier(MemberInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public MemberInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case MemberInheritanceModifier.Abstract:
                    builder.Append(InheritanceModifierText.AbstractText);
                    break;
                case MemberInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
                case MemberInheritanceModifier.Override:
                    builder.Append(InheritanceModifierText.OverrideText);
                    break;
                case MemberInheritanceModifier.Static:
                    builder.Append(InheritanceModifierText.StaticText);
                    break;
                case MemberInheritanceModifier.Virtual:
                    builder.Append(InheritanceModifierText.VirtualText);
                    break;
            }
        }
    }
}
