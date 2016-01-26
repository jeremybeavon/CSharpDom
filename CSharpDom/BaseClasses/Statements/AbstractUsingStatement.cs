using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractUsingStatement<TExpression, TStatement> :
        IUsingStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Expression { get; }

        public abstract TStatement Statement { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitUsingStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitUsingStatementChildren(this, visitor);
        }
    }
}
