namespace CSharpDom.Text.Steps
{
    public sealed class WriteMemberVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteMemberVisibilityModifier(MemberVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public MemberVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case MemberVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case MemberVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case MemberVisibilityModifier.Protected:
                    builder.Append(VisibilityText.ProtectedText);
                    break;
                case MemberVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
