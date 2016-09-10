using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class MethodCallExpressionWithCodeAnalysis<TExpression> : IMethodCallExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract IList<TExpression> ParameterExpressions { get; set; }

        IReadOnlyList<TExpression> IMethodCallExpression<TExpression>.ParameterExpressions
        {
            get { return new ReadOnlyCollection<TExpression>(ParameterExpressions); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMethodCallExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMethodCallExpressionChildren(this, visitor);
        }
    }
}
