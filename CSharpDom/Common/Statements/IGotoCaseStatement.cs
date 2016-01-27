namespace CSharpDom.Common.Statements
{
    public interface IGotoCaseStatement : IStatement
    {
        string CaseName { get; }
    }
}
