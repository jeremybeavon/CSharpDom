using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedStaticClassFactory : AbstractFactory<IClassNestedStaticClass, ClassNestedStaticClass>
    {
        public ClassNestedStaticClassFactory(IClassNestedStaticClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Value = new ClassNestedStaticClass()
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
