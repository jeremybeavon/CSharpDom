using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractLambdaExpression<TParameter, TStatement> :
        ILambdaExpression<TParameter, TStatement>
        where TParameter : IParameter
        where TStatement : IStatement
    {
        public abstract TStatement Body { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitLambdaExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
