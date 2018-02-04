using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableCatchStatement : IVisitable<IEditableStatementVisitor>, ICatchStatement
    {
    }
}