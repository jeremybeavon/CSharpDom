using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableThrowStatement<TExpression> :
        EditableStatement,
        IEditableThrowStatement<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitThrowStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitThrowStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
        }
    }
}
