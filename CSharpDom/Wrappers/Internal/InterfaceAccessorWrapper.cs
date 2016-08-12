using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceAccessorWrapper : AbstractWrapper<IInterfaceAccessor>
    {
        public InterfaceAccessorWrapper(IInterfaceAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitInterfaceAccessor<TAttributeGroup>(
            IInterfaceAccessor<TAttributeGroup> accessor)
        {
            Value = new InterfaceAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingWrapper()
            };
        }
    }
}
