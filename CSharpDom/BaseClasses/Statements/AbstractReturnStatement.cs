using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractReturnStatement<TExpression> :
        AbstractStatement,
        IReturnStatement<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitReturnStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
