using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NewArrayExpressionWithCodeAnalysis<TTypeReference, TExpression> :
        INewArrayExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IList<int> Dimensions { get; set; }

        public abstract TTypeReference ElementType { get; set; }

        public abstract IList<TExpression> InitialSizeExpressions { get; set; }

        IReadOnlyList<int> INewArrayExpression<TTypeReference, TExpression>.Dimensions
        {
            get { return new ReadOnlyCollection<int>(Dimensions); }
        }

        IReadOnlyList<TExpression> INewArrayExpression<TTypeReference, TExpression>.InitialSizeExpressions
        {
            get { return new ReadOnlyCollection<TExpression>(InitialSizeExpressions); }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewArrayExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewArrayExpressionChildren(this, visitor);
        }
    }
}
