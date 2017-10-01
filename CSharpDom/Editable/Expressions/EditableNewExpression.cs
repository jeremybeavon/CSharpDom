using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableNewExpression<TTypeReference, TExpression> :
        AbstractExpression,
        INewExpression<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IList<TExpression> Parameters { get; set; }

        public abstract TTypeReference Type { get; set; }

        IReadOnlyList<TExpression> INewExpression<TTypeReference, TExpression>.Parameters
        {
            get { return new ReadOnlyCollection<TExpression>(Parameters); }
        }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitNewExpressionChildren(this, visitor);
        }
    }
}
