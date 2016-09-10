using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class TypeofExpressionWithCodeAnalysis<TTypeReference> :
        ITypeofExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTypeofExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
