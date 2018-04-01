using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class MethodCallExpression : IMethodCallExpression<Expression, TypeReference, Argument>
    {
        public MethodCallExpression()
        {
            Parameters = new List<Argument>();
        }
        
        public Expression Expression { get; set; }

        public List<TypeReference> GenericParameters { get; set; }

        public List<Argument> Parameters { get; set; }

        IReadOnlyList<Argument> IMethodCallExpression<Expression, TypeReference, Argument>.Parameters
        {
            get { return Parameters; }
        }

        IReadOnlyList<TypeReference> IMethodCallExpression<Expression, TypeReference, Argument>.GenericParameters =>
            GenericParameters;

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
