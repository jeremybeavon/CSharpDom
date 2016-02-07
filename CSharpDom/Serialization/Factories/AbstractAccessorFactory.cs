using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractAccessorFactory : AbstractFactory<IAbstractAccessor, AbstractAccessor>
    {
        public AbstractAccessorFactory(IAbstractAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitAbstractAccessor<TAttributeGroup>(
            IAbstractAccessor<TAttributeGroup> accessor)
        {
            Value = new AbstractAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory()
            };
        }
    }
}
