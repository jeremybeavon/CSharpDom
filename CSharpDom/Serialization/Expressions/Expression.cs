using CSharpDom.Common.Expressions;
using System;

namespace CSharpDom.Serialization.Expressions
{
    public sealed class Expression : IExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
