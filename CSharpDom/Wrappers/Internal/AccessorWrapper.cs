using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AccessorWrapper : AbstractWrapper<IAccessor>
    {
        public AccessorWrapper(IAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(
            IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new Accessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(accessor.Body).Value
            };
        }
    }
}
