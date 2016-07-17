namespace CSharpDom.Text.Steps
{
    public sealed class WriteStaticClassFieldModifier : ISourceCodeBuilderStep
    {
        public WriteStaticClassFieldModifier(StaticClassFieldModifier modifier)
        {
            Modifier = modifier;
        }

        public StaticClassFieldModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case StaticClassFieldModifier.ReadOnly:
                    builder.Append("readonly");
                    break;
                case StaticClassFieldModifier.Volatile:
                    builder.Append("volatile");
                    break;
            }
        }
    }
}
