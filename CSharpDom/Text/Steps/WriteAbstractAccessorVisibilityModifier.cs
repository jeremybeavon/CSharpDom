namespace CSharpDom.Text.Steps
{
    public sealed class WriteAbstractAccessorVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteAbstractAccessorVisibilityModifier(AbstractAccessorVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public AbstractAccessorVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case AbstractAccessorVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case AbstractAccessorVisibilityModifier.Protected:
                    builder.Append(VisibilityText.ProtectedText);
                    break;
            }
        }
    }
}
