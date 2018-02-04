using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableStatement : IVisitable<IEditableStatementVisitor>, IStatement
    {
    }
}