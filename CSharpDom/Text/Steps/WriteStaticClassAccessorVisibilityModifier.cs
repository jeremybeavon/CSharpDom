namespace CSharpDom.Text.Steps
{
    public sealed class WriteStaticClassAccessorVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteStaticClassAccessorVisibilityModifier(StaticClassAccessorVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public StaticClassAccessorVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StaticClassAccessorVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case StaticClassAccessorVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
