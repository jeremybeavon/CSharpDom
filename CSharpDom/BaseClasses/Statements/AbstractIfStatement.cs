using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractIfStatement<TExpression, TStatement> :
        IIfStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; }

        public abstract TStatement ElseStatement { get; }

        public abstract TStatement ThenStatement { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitIfStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitIfStatementChildren(this, visitor);
        }
    }
}
