using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassAutoPropertyAccessor<TAttributeGroup> :
        AbstractAutoPropertyAccessor<TAttributeGroup>,
        IClassAutoPropertyAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public abstract ClassAccessorVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAutoPropertyAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassAutoPropertyAccessorChildren(this, visitor);
        }
    }
}
