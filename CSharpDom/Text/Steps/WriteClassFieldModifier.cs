namespace CSharpDom.Text.Steps
{
    public sealed class WriteClassFieldModifier : ISourceCodeBuilderStep
    {
        public WriteClassFieldModifier(ClassFieldModifier modifier)
        {
            Modifier = modifier;
        }

        public ClassFieldModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case ClassFieldModifier.Const:
                    builder.Append("const");
                    break;
                case ClassFieldModifier.ReadOnly:
                    builder.Append("readonly");
                    break;
                case ClassFieldModifier.Static:
                    builder.Append("static");
                    break;
                case ClassFieldModifier.Volatile:
                    builder.Append("volatile");
                    break;
            }
        }
    }
}
