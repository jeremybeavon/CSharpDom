namespace CSharpDom.Text.Steps
{
    public sealed class WriteTypeInheritanceModifier : ISourceCodeBuilderStep
    {
        public WriteTypeInheritanceModifier(TypeInheritanceModifier inheritanceModifier)
        {
            InheritanceModifier = inheritanceModifier;
        }

        public TypeInheritanceModifier InheritanceModifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (InheritanceModifier)
            {
                case TypeInheritanceModifier.Abstract:
                    builder.Append(InheritanceModifierText.AbstractText);
                    break;
                case TypeInheritanceModifier.Sealed:
                    builder.Append(InheritanceModifierText.SealedText);
                    break;
                case TypeInheritanceModifier.Static:
                    builder.Append(InheritanceModifierText.StaticText);
                    break;
            }
        }
    }
}
