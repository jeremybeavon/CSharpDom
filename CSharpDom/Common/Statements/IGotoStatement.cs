namespace CSharpDom.Common.Statements
{
    public interface IGotoStatement : IStatement
    {
        string LabelName { get; }
    }
}
