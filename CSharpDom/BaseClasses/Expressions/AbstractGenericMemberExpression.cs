using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractGenericMemberExpression<TExpression, TTypeReference> :
        AbstractExpression,
        IGenericMemberExpression<TExpression, TTypeReference>
        where TExpression : IExpression
        where TTypeReference : ITypeReference
    {
        public abstract string MemberName { get; }

        public abstract TExpression ObjectExpression { get; }

        public abstract IReadOnlyList<TTypeReference> GenericParameters { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitGenericMemberExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitGenericMemberExpressionChildren(this, visitor);
        }
    }
}
