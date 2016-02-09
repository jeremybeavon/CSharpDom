using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class AnonymousMethodExpression : IAnonymousMethodExpression<Parameter, Statement>
    {
        public AnonymousMethodExpression()
        {
            Parameters = new List<Parameter>();
        }

        public Statement Body { get; set; }

        public List<Parameter> Parameters { get; set; }

        IReadOnlyList<Parameter> IAnonymousMethodExpression<Parameter, Statement>.Parameters
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
