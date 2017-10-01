using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableUnnamedAttributeValue<TExpression> :
        AbstractGenericVisitableObject,
        IUnnamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Value { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitUnnamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
