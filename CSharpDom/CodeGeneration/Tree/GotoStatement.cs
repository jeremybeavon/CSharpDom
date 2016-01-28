namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GotoStatement : Statement
    {
        public LabelReference Label { get; set; }
    }
}
