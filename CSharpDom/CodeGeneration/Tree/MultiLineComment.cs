namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class MultiLineComment : Statement
    {
        public MultiLineComment(string comment)
        {
            Comment = comment;
        }

        public string Comment { get; set; }
    }
}
