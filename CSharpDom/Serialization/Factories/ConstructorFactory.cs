using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ConstructorFactory : AbstractFactory<IConstructor, Constructor>
    {
        public ConstructorFactory(IConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
        {
            Value = new Constructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingFactory(),
                Parameters = constructor.Parameters.ToParameterListUsingFactory(),
                Visibility = constructor.Visibility
            };
        }
    }
}
