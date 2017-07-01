using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedStaticClassFactory : AbstractFactory<IStructNestedStaticClass, StructNestedStaticClass>
    {
        public StructNestedStaticClassFactory(IStructNestedStaticClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Value = new StructNestedStaticClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingFactory(),
                Classes = new StaticClassNestedClassCollectionFactory(nestedClass.Classes).Value,
                Delegates = nestedClass.Delegates.ToList(@delegate => new StaticClassNestedDelegateFactory(@delegate).Value),
                Enums = nestedClass.Enums.ToList(@enum => new StaticClassNestedEnumFactory(@enum).Value),
                Events = new StaticClassEventCollectionFactory(nestedClass.Events).Value,
                Fields = new StaticClassFieldCollectionFactory(nestedClass.Fields).Value,
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Interfaces = new StaticClassNestedInterfaceCollectionFactory(nestedClass.Interfaces).Value,
                Methods = new NestedStaticClassMethodCollectionFactory(nestedClass.Methods).Value,
                Name = nestedClass.Name,
                Properties = nestedClass.Properties.ToList(property => new StaticClassPropertyFactory(property).Value),
                StaticConstructor = new StaticConstructorFactory(nestedClass.StaticConstructor).Value,
                Structs = new StaticClassNestedStructCollectionFactory(nestedClass.Structs).Value,
                Visibility = nestedClass.Visibility
            };
        }
    }
}
