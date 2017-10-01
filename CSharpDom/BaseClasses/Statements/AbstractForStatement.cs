using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractForStatement<TExpression, TForInitializerStatement, TStatement> :
        AbstractStatement,
        IForStatement<TExpression, TForInitializerStatement, TStatement>
        where TExpression : IExpression
        where TForInitializerStatement : IForInitializerStatement
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; }

        public abstract IReadOnlyCollection<TExpression> IncrementExpressions { get; }

        public abstract TForInitializerStatement InitialValueStatement { get; }

        public abstract TStatement Statement { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForStatementChildren(this, visitor);
        }
    }
}
