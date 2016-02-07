using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassAccessorFactory : AbstractFactory<ISealedClassAccessor, SealedClassAccessor>
    {
        public SealedClassAccessorFactory(ISealedClassAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitSealedClassAccessor<TAttributeGroup, TMethodBody>(
            ISealedClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new SealedClassAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(accessor.Body).Value//,
                //Visibility = accessor.Visibility
            };
        }
    }
}
