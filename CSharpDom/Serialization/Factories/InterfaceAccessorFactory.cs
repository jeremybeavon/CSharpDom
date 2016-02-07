using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceAccessorFactory : AbstractFactory<IInterfaceAccessor, InterfaceAccessor>
    {
        public InterfaceAccessorFactory(IInterfaceAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitInterfaceAccessor<TAttributeGroup>(
            IInterfaceAccessor<TAttributeGroup> accessor)
        {
            Value = new InterfaceAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory()
            };
        }
    }
}
