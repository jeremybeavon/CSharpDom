using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableDefaultExpression<TTypeReference> :
        AbstractExpression,
        IDefaultExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDefaultExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
