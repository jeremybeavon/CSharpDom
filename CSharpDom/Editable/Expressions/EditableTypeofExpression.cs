using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableTypeofExpression<TTypeReference> :
        AbstractExpression,
        ITypeofExpression<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference Type { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTypeofExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
