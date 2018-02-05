namespace CSharpDom.Common.Statements
{
    public interface ICheckedStatement<TStatement> : ICheckedStatement
        where TStatement : IStatement
    {
        TStatement Statement { get; }
    }
}
