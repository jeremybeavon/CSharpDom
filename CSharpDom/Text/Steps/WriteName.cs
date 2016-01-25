namespace CSharpDom.Text.Steps
{
    public sealed class WriteName : ISourceCodeBuilderStep
    {
        public WriteName(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(Name);
        }
    }
}
