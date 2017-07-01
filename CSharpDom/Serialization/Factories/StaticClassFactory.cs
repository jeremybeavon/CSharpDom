using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassFactory : AbstractFactory<IStaticClass, StaticClass>
    {
        public StaticClassFactory(IStaticClass @class)
            : base(@class)
        {
        }

        public override void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
        {
            Value = new StaticClass()
            {
                Attributes = @class.Attributes.ToAttributeListUsingFactory(),
                Classes = new StaticClassNestedClassCollectionFactory(@class.Classes).Value,
                Delegates = @class.Delegates.ToList(@delegate => new StaticClassNestedDelegateFactory(@delegate).Value),
                Enums = @class.Enums.ToList(@enum => new StaticClassNestedEnumFactory(@enum).Value),
                Events = new StaticClassEventCollectionFactory(@class.Events).Value,
                Fields = new StaticClassFieldCollectionFactory(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Interfaces = @class.Interfaces.ToList(@interface => new StaticClassNestedInterfaceFactory(@interface).Value),
                Methods = new StaticClassMethodCollectionFactory(@class.Methods).Value,
                Name = @class.Name,
                Properties = @class.Properties.ToList(property => new StaticClassPropertyFactory(property).Value),
                StaticConstructor = new StaticConstructorFactory(@class.StaticConstructor).Value,
                Structs = new StaticClassNestedStructCollectionFactory(@class.Structs).Value,
                Visibility = @class.Visibility
            };
            if (Value.StaticConstructor != null)
            {
                Value.StaticConstructor.AttachDeclaringType(@class);
            }
        }
    }
}
