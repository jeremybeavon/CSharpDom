using CSharpDom.Common.Statements;

namespace CSharpDom.Common.Editable.Statements
{
    public interface IEditableSwitchCaseStatement : IVisitable<IEditableStatementVisitor>, ISwitchCaseStatement
    {
    }
}