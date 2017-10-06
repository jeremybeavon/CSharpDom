using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableWhileStatement<TExpression, TStatement> :
        AbstractStatement,
        IWhileStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement Statement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitWhileStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitWhileStatementChildren(this, visitor);
        }
    }
}
