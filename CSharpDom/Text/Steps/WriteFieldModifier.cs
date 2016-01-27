namespace CSharpDom.Text.Steps
{
    public sealed class WriteFieldModifier : ISourceCodeBuilderStep
    {
        public WriteFieldModifier(FieldModifier modifier)
        {
            Modifier = modifier;
        }

        public FieldModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case FieldModifier.Const:
                    builder.Append("const");
                    break;
                case FieldModifier.ReadOnly:
                    builder.Append("readonly");
                    break;
                case FieldModifier.Static:
                    builder.Append("static");
                    break;
                case FieldModifier.Volatile:
                    builder.Append("volatile");
                    break;
            }
        }
    }
}
