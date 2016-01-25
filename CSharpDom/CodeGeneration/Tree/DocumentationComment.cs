namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DocumentationComment : Statement
    {
        public DocumentationComment(string comment)
        {
            Comment = comment;
        }

        public string Comment { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
        }
    }
}
