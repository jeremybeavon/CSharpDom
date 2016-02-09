using System;
using System.Collections.Generic;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class NewArrayExpression : INewArrayExpression<TypeReference, Expression>
    {
        public NewArrayExpression()
        {
            Dimensions = new List<int>();
            InitialSizeExpressions = new List<Expression>();
        }

        public List<int> Dimensions { get; set; }

        public TypeReference ElementType { get; set; }

        public List<Expression> InitialSizeExpressions { get; set; }

        IReadOnlyList<int> INewArrayExpression<TypeReference, Expression>.Dimensions
        {
            get { return Dimensions; }
        }

        IReadOnlyList<Expression> INewArrayExpression<TypeReference, Expression>.InitialSizeExpressions
        {
            get { return InitialSizeExpressions; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewArrayExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewArrayExpressionChildren(this, visitor);
        }
    }
}
