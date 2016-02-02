namespace CSharpDom.Text.Steps
{
    public sealed class WriteMemberVisibilityModifier : ISourceCodeBuilderStep
    {
        public WriteMemberVisibilityModifier(ClassMemberVisibilityModifier modifier)
        {
            Modifier = modifier;
        }

        public ClassMemberVisibilityModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case ClassMemberVisibilityModifier.Public:
                    builder.Append(VisibilityText.PublicText);
                    break;
                case ClassMemberVisibilityModifier.Internal:
                    builder.Append(VisibilityText.InternalText);
                    break;
                case ClassMemberVisibilityModifier.Protected:
                    builder.Append(VisibilityText.ProtectedText);
                    break;
                case ClassMemberVisibilityModifier.Private:
                    builder.Append(VisibilityText.PrivateText);
                    break;
            }
        }
    }
}
