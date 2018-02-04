using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableDefaultCaseStatement : IVisitable<IEditableStatementVisitor>, IDefaultCaseStatement
    {
    }
}