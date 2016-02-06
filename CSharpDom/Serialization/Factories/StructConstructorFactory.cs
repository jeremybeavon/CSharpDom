using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructConstructorFactory : AbstractFactory<IStructConstructor, StructConstructor>
    {
        public StructConstructorFactory(IStructConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Value = new StructConstructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingFactory(),
                Parameters = constructor.Parameters.ToParameterListUsingFactory(),
                Visibility = constructor.Visibility
            };
        }
    }
}
