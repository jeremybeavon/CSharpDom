namespace CSharpDom.Text.Steps
{
    public sealed class WriteInterfaceMemberInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteInterfaceMemberInheritanceModifier(InterfaceMemberInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public InterfaceMemberInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case InterfaceMemberInheritanceModifier.New:
                    builder.Append(InheritanceModifierText.NewText);
                    break;
            }
        }
    }
}
