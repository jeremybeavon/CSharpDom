using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class IdentifierExpressionWithCodeAnalysis : IIdentifierExpression
    {
        public abstract string Name { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
