namespace CSharpDom.Text.Steps
{
    public sealed class WriteClassMemberInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteClassMemberInheritanceModifier(ClassMemberInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public ClassMemberInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case ClassMemberInheritanceModifier.Abstract:
                    builder.Append(InheritanceModifierText.AbstractText);
                    break;
                case ClassMemberInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
                case ClassMemberInheritanceModifier.Override:
                    builder.Append(InheritanceModifierText.OverrideText);
                    break;
                case ClassMemberInheritanceModifier.Static:
                    builder.Append(InheritanceModifierText.StaticText);
                    break;
                case ClassMemberInheritanceModifier.Virtual:
                    builder.Append(InheritanceModifierText.VirtualText);
                    break;
            }
        }
    }
}
