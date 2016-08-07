using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassAccessorFactory : AbstractFactory<IStaticClassAccessor, StaticClassAccessor>
    {
        public StaticClassAccessorFactory(IStaticClassAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new StaticClassAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(accessor.Body).Value,
                Visibility = accessor.Visibility
            };
        }
    }
}
