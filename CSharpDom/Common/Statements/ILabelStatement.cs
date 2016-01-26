namespace CSharpDom.Common.Statements
{
    public interface ILabelStatement : IStatement
    {
        string LabelName { get; }
    }
}
