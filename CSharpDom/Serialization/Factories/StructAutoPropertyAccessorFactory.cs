using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructAutoPropertyAccessorFactory :
        AbstractFactory<IStructAutoPropertyAccessor, StructAutoPropertyAccessor>
    {
        public StructAutoPropertyAccessorFactory(IStructAutoPropertyAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStructAutoPropertyAccessor<TAttributeGroup>(
            IStructAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            Value = new StructAutoPropertyAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Visibility = accessor.Visibility
            };
        }
    }
}
