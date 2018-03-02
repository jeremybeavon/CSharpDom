using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassAutoPropertyAccessorFactory :
        AbstractFactory<IClassAutoPropertyAccessor, ClassAutoPropertyAccessor>
    {
        public ClassAutoPropertyAccessorFactory(IClassAutoPropertyAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitClassAutoPropertyAccessor<TAttributeGroup>(
            IClassAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            Value = new ClassAutoPropertyAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Visibility = accessor.Visibility
            };
        }
    }
}
