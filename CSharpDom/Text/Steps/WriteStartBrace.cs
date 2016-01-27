namespace CSharpDom.Text.Steps
{
    public class WriteStartBrace : ISourceCodeBuilderStep
    {
        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append("{");
        }
    }
}
