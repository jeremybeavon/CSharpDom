using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAutoPropertyAccessor<TAttributeGroup> :
        AbstractAccessor<TAttributeGroup>,
        IAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAutoPropertyAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAutoPropertyAccessorChildren(this, visitor);
        }
    }
}
