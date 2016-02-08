using System;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class DefaultExpression : IDefaultExpression<TypeReference>
    {
        public TypeReference Type { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDefaultExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
