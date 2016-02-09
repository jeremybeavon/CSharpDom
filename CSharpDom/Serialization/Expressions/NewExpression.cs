using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class NewExpression : INewExpression<TypeReference, Expression>
    {
        public NewExpression()
        {
            Parameters = new List<Expression>();
        }

        public List<Expression> Parameters { get; set; }

        public TypeReference Type { get; set; }

        IReadOnlyList<Expression> INewExpression<TypeReference, Expression>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }
    }
}
