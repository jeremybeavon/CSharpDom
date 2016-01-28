namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LabelReference : Statement
    {
        public LabelReference(string label)
        {
            Label = label;
        }

        public string Label { get; set; }
    }
}
