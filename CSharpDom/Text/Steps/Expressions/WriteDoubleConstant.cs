namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteDoubleConstant : ISourceCodeBuilderStep
    {
        public WriteDoubleConstant(double constant)
        {
            Constant = constant;
        }

        public double Constant { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(Constant.ToString());
        }
    }
}
