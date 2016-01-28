namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DocumentationComment : Statement
    {
        public DocumentationComment(string comment)
        {
            Comment = comment;
        }

        public string Comment { get; set; }
    }
}
