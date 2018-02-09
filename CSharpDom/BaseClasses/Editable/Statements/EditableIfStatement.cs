using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableIfStatement<TExpression, TStatement> :
        EditableStatement,
        IEditableIfStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement ElseStatement { get; set; }

        public abstract TStatement ThenStatement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitIfStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitIfStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitIfStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
