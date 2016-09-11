using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class BinaryOperatorExpressionWithCodeAnalysis<TExpression> : IBinaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Left { get; set; }

        public abstract BinaryOperatorExpressionType OperatorType { get; set; }

        public abstract TExpression Right { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
        }
    }
}
