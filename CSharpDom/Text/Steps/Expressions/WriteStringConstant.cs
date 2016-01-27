namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteStringConstant : ISourceCodeBuilderStep
    {
        public WriteStringConstant(string constant)
        {
            Constant = constant;
        }

        public string Constant { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(Constant);
        }
    }
}
