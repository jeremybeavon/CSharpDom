namespace CSharpDom.Text.Steps
{
    public sealed class WriteStaticClassMemberVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteStaticClassMemberVisibilityModifier(StaticClassMemberVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public StaticClassMemberVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StaticClassMemberVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case StaticClassMemberVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case StaticClassMemberVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
