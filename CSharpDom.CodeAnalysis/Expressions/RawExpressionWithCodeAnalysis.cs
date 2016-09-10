using System;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class RawExpressionWithCodeAnalysis : IRawExpression
    {
        public abstract string Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRawExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
