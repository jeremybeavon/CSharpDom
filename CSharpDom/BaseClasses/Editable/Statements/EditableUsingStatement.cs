using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableUsingStatement<TExpression, TStatement> :
        EditableStatement,
        IEditableUsingStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        public abstract TExpression Expression { get; set; }

        public abstract TStatement Statement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitUsingStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitUsingStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitUsingStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
