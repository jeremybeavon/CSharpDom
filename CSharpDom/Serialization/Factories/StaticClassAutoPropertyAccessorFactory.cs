using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassAutoPropertyAccessorFactory :
        AbstractFactory<IStaticClassAutoPropertyAccessor, StaticClassAutoPropertyAccessor>
    {
        public StaticClassAutoPropertyAccessorFactory(IStaticClassAutoPropertyAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitStaticClassAutoPropertyAccessor<TAttributeGroup>(
            IStaticClassAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            Value = new StaticClassAutoPropertyAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Visibility = accessor.Visibility
            };
        }
    }
}
