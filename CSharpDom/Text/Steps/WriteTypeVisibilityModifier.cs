namespace CSharpDom.Text.Steps
{
    public sealed class WriteTypeVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteTypeVisibilityModifier(TypeVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public TypeVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case TypeVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case TypeVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
            }
        }
    }
}
