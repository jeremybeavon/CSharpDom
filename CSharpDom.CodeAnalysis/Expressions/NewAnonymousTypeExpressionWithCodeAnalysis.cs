using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NewAnonymousTypeExpressionWithCodeAnalysis : INewAnonymousTypeExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousTypeExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
