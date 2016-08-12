using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassAccessorWrapper : AbstractWrapper<IStaticClassAccessor>
    {
        public StaticClassAccessorWrapper(IStaticClassAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new StaticClassAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
