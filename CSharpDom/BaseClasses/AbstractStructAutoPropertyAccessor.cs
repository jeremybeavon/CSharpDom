using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructAutoPropertyAccessor<TAttributeGroup> :
        AbstractAutoPropertyAccessor<TAttributeGroup>,
        IStructAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract StructAccessorVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructAutoPropertyAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructAutoPropertyAccessorChildren(this, visitor);
        }
    }
}
