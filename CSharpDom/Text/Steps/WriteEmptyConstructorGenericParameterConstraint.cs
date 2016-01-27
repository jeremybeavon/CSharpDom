namespace CSharpDom.Text.Steps
{
    public sealed class WriteEmptyConstructorGenericParameterConstraint : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("new()");
        }
    }
}
