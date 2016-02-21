using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticConstructorFactory : AbstractFactory<IStaticConstructor, StaticConstructor>
    {
        public StaticConstructorFactory(IStaticConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
        {
            Value = new StaticConstructor()
            {
                Attributes = staticConstructor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(staticConstructor.Body).Value
            };
        }
    }
}
