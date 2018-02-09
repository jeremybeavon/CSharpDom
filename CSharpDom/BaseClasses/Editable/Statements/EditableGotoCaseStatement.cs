using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableGotoCaseStatement : EditableStatement, IEditableGotoCaseStatement
    {
        public abstract string CaseName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
        }
    }
}
