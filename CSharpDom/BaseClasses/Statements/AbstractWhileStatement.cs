using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractWhileStatement<TExpression, TStatement> :
        AbstractStatement,
        IWhileStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; }

        public abstract TStatement Statement { get; }

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
