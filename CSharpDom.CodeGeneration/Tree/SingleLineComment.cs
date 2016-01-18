namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SingleLineComment : Statement
    {
        public SingleLineComment(string comment)
        {
            Comment = comment;
        }
        
        public string Comment { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
