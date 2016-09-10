using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class IntegerConstantExpressionWithCodeAnalysis : IIntegerConstantExpression
    {
        public abstract int Constant { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIntegerConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
