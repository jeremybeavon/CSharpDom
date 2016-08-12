using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructAccessorWrapper : AbstractWrapper<IStructAccessor>
    {
        public StructAccessorWrapper(IStructAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStructAccessor<TAttributeGroup, TMethodBody>(
            IStructAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new StructAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
