using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractUsingStatement<TExpression, TStatement> :
        AbstractStatement,
        IUsingStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; }

        public abstract TStatement Statement { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitUsingStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitUsingStatementChildren(this, visitor);
        }
    }
}
