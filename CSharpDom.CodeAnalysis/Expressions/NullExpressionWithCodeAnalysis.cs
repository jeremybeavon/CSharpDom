using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NullExpressionWithCodeAnalysis : INullExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
