using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedStaticClassWrapper : AbstractWrapper<IStaticClassNestedStaticClass>
    {
        public StaticClassNestedStaticClassWrapper(IStaticClassNestedStaticClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass)
        {
            Value = new StaticClassNestedStaticClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingWrapper(),
                Classes = new StaticClassNestedClassCollectionWrapper(nestedClass.Classes).Value,
                Delegates = nestedClass.Delegates.ToList(@delegate => new StaticClassNestedDelegateWrapper(@delegate).Value),
                Enums = nestedClass.Enums.ToList(@enum => new StaticClassNestedEnumWrapper(@enum).Value),
                Events = new StaticClassEventCollectionWrapper(nestedClass.Events).Value,
                Fields = new StaticClassFieldCollectionWrapper(nestedClass.Fields).Value,
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Interfaces = new StaticClassNestedInterfaceCollectionWrapper(nestedClass.Interfaces).Value,
                Methods = new NestedStaticClassMethodCollectionWrapper(nestedClass.Methods).Value,
                Name = nestedClass.Name,
                Properties = nestedClass.Properties.ToList(property => new StaticClassPropertyWrapper(property).Value),
                StaticConstructor = new StaticConstructorWrapper(nestedClass.StaticConstructor).Value,
                Structs = new StaticClassNestedStructCollectionWrapper(nestedClass.Structs).Value,
                Visibility = nestedClass.Visibility
            };
            if (Value.StaticConstructor != null)
            {
                Value.StaticConstructor.AttachDeclaringType(nestedClass);
            }
        }
    }
}
