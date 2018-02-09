using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Editable.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableStatement : AbstractStatement, IEditableStatement
    {
        public abstract void Accept(IEditableStatementVisitor visitor);

        public abstract void AcceptChildren(IEditableStatementVisitor visitor);
    }
}
