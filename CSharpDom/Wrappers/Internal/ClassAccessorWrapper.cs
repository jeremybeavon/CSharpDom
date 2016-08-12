using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassAccessorWrapper : AbstractWrapper<IClassAccessor>
    {
        public ClassAccessorWrapper(IClassAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(
            IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new ClassAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
