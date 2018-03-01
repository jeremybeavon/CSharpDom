using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedStaticClassFactory : AbstractFactory<IStaticClassNestedStaticClass, StaticClassNestedStaticClass>
    {
        public StaticClassNestedStaticClassFactory(IStaticClassNestedStaticClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Value = new StaticClassNestedStaticClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingFactory(),
                Classes = new StaticClassNestedClassCollectionFactory(nestedClass.Classes).Value,
                Delegates = nestedClass.Delegates.ToList(@delegate => new StaticClassNestedDelegateFactory(@delegate).Value),
                Enums = nestedClass.Enums.ToList(@enum => new StaticClassNestedEnumFactory(@enum).Value),
                Events = new StaticClassEventCollectionFactory(nestedClass.Events).Value,
                Fields = new StaticClassFieldCollectionFactory(nestedClass.Fields).Value,
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Interfaces = nestedClass.Interfaces.ToList(@interface => new StaticClassNestedInterfaceFactory(@interface).Value),
                Methods = new NestedStaticClassMethodCollectionFactory(nestedClass.Methods).Value,
                Name = nestedClass.Name,
                Properties = new StaticClassPropertyCollectionFactory(nestedClass.Properties).Value,
                StaticConstructor = new StaticConstructorFactory(nestedClass.StaticConstructor).Value,
                Structs = new StaticClassNestedStructCollectionFactory(nestedClass.Structs).Value,
                Visibility = nestedClass.Visibility
            };
            if (Value.StaticConstructor != null)
            {
                Value.StaticConstructor.AttachDeclaringType(nestedClass);
            }
        }
    }
}
