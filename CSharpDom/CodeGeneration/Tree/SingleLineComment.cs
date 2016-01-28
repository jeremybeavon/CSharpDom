namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SingleLineComment : Statement
    {
        public SingleLineComment(string comment)
        {
            Comment = comment;
        }
        
        public string Comment { get; set; }
    }
}
