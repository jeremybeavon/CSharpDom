using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructAccessorFactory : AbstractFactory<IStructAccessor, StructAccessor>
    {
        public StructAccessorFactory(IStructAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStructAccessor<TAttributeGroup, TMethodBody>(
            IStructAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new StructAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
