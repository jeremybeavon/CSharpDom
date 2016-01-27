namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteIntegerConstant : ISourceCodeBuilderStep
    {
        public WriteIntegerConstant(int constant)
        {
            Constant = constant;
        }

        public int Constant { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(Constant.ToString());
        }
    }
}
