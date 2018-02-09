using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableGotoStatement : EditableStatement, IEditableGotoStatement
    {
        public abstract string LabelName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitGotoStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
        }
    }
}
