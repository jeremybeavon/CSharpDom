namespace CSharpDom.Text.Steps
{
    public sealed class WriteStructFieldModifier : ISourceCodeBuilderStep
    {
        public WriteStructFieldModifier(StructFieldModifier modifier)
        {
            Modifier = modifier;
        }

        public StructFieldModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StructFieldModifier.ReadOnly:
                    builder.Append("readonly");
                    break;
                case StructFieldModifier.Static:
                    builder.Append("static");
                    break;
                case StructFieldModifier.Volatile:
                    builder.Append("volatile");
                    break;
            }
        }
    }
}
