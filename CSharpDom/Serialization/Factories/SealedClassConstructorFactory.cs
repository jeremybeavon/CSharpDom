using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassConstructorFactory : AbstractFactory<ISealedClassConstructor, SealedClassConstructor>
    {
        public SealedClassConstructorFactory(ISealedClassConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitSealedClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            ISealedClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Value = new SealedClassConstructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingFactory(),
                Parameters = constructor.Parameters.ToParameterListUsingFactory(),
                Visibility = constructor.Visibility
            };
        }
    }
}
