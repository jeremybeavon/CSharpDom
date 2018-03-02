using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassAutoPropertyAccessor<TAttributeGroup> :
        AbstractAutoPropertyAccessor<TAttributeGroup>,
        IStaticClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract StaticClassAccessorVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAutoPropertyAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassAutoPropertyAccessorChildren(this, visitor);
        }
    }
}
