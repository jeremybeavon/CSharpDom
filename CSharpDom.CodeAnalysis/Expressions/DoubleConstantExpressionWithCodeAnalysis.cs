using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class DoubleConstantExpressionWithCodeAnalysis : IDoubleConstantExpression
    {
        public abstract double Constant { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
