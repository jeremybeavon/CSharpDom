using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AccessorFactory : AbstractFactory<IAccessor, Accessor>
    {
        public AccessorFactory(IAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new Accessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
