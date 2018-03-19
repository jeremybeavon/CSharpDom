using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class AnonymousMethodExpression :
        IAnonymousMethodExpression<AnonymousMethodParameter, Statement>
    {
        public AnonymousMethodExpression()
        {
            Parameters = new List<AnonymousMethodParameter>();
        }

        public bool IsAsync { get; set; }

        public List<Statement> Statements { get; set; }

        public List<AnonymousMethodParameter> Parameters { get; set; }

        IReadOnlyList<AnonymousMethodParameter> IAnonymousMethodExpression<AnonymousMethodParameter, Statement>.Parameters
        {
            get { return Parameters; }
        }

        IReadOnlyList<Statement> IAnonymousMethodExpression<AnonymousMethodParameter, Statement>.Statements => Statements;

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitAnonymousMethodExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
