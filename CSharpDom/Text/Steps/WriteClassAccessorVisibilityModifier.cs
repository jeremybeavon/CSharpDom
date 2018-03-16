namespace CSharpDom.Text.Steps
{
    public sealed class WriteClassAccessorVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteClassAccessorVisibilityModifier(ClassAccessorVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public ClassAccessorVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case ClassAccessorVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case ClassAccessorVisibilityModifier.Protected:
                    builder.Append(VisibilityText.ProtectedText);
                    break;
                case ClassAccessorVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
