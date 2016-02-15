using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class AnonymousMethodExpression : IAnonymousMethodExpression<MethodParameter, Statement>
    {
        public AnonymousMethodExpression()
        {
            Parameters = new List<MethodParameter>();
        }

        public Statement Body { get; set; }

        public List<MethodParameter> Parameters { get; set; }

        IReadOnlyList<MethodParameter> IAnonymousMethodExpression<MethodParameter, Statement>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
