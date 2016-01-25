namespace CSharpDom.Text.Steps
{
    public class WriteEndBrace : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("}");
        }
    }
}
