namespace CSharpDom.Text.Steps
{
    public sealed class WriteStructAccessorVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteStructAccessorVisibilityModifier(StructAccessorVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public StructAccessorVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StructAccessorVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case StructAccessorVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
