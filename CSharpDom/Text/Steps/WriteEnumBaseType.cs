namespace CSharpDom.Text.Steps
{
    public sealed class WriteEnumBaseType : ISourceCodeBuilderStep
    {
        public WriteEnumBaseType(EnumBaseType baseType)
        {
            BaseType = baseType;
        }

        public EnumBaseType BaseType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(BaseType.ToString().ToLower());
        }
    }
}
