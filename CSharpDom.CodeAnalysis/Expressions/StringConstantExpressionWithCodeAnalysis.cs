using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class StringConstantExpressionWithCodeAnalysis : IStringConstantExpression
    {
        public abstract string Constant { get; set; }

        public abstract bool HasAtSymbol { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
