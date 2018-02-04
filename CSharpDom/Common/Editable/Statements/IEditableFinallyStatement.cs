using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableFinallyStatement : IVisitable<IEditableStatementVisitor>, IFinallyStatement
    {
    }
}