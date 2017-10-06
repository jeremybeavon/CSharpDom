using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableLockStatement<TExpression, TStatement> :
        AbstractStatement,
        ILockStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; set; }

        public abstract TStatement Statement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLockStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitLockStatementChildren(this, visitor);
        }
    }
}
