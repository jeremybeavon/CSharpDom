namespace CSharpDom.Text.Steps
{
    public sealed class WriteAbstractMemberVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteAbstractMemberVisibilityModifier(AbstractMemberVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public AbstractMemberVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case AbstractMemberVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case AbstractMemberVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case AbstractMemberVisibilityModifier.Protected:
                    builder.Append(VisibilityText.ProtectedText);
                    break;
            }
        }
    }
}
