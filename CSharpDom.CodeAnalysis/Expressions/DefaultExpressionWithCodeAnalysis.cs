using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class DefaultExpressionWithCodeAnalysis<TTypeReference> :
        IDefaultExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDefaultExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
