using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassConstructorFactory : AbstractFactory<IClassConstructor, ClassConstructor>
    {
        public ClassConstructorFactory(IClassConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            Value = new ClassConstructor()
            {
                Attributes = constructor.Attributes.ToAttributeListUsingFactory(),
                Parameters = constructor.Parameters.ToParameterListUsingFactory(),
                Visibility = constructor.Visibility
            };
        }
    }
}
