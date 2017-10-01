using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable
{
    public abstract class EditableNamedAttributeValue<TExpression> :
        AbstractGenericVisitableObject,
        INamedAttributeValue<TExpression>
        where TExpression : IExpression
    {
        public abstract string Name { get; set; }

        public abstract TExpression Value { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamedAttributeValue(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }
    }
}
