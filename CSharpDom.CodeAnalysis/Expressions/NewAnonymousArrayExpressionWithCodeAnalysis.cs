using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NewAnonymousArrayExpressionWithCodeAnalysis : INewAnonymousArrayExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousArrayExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
