using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableGotoStatement : AbstractStatement, IGotoStatement
    {
        public abstract string LabelName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
