namespace CSharpDom.Text.Steps
{
    public sealed class WriteStructMemberVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteStructMemberVisibilityModifier(StructMemberVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public StructMemberVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StructMemberVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case StructMemberVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case StructMemberVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
