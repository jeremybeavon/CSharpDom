using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractSwitchStatement<TExpression, TSwitchCaseStatement, TStatement> :
        ISwitchStatement<TExpression, TSwitchCaseStatement, TStatement>
        where TExpression : IExpression
        where TSwitchCaseStatement : ISwitchCaseStatement
        where TStatement : IStatement
    {
        public abstract IReadOnlyCollection<TSwitchCaseStatement> Cases { get; }

        public abstract IReadOnlyList<TStatement> DefaultCase { get; }

        public abstract TExpression Expression { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }
    }
}
