using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableEmptyStatement : EditableStatement, IEditableEmptyStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
        }
    }
}
