using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructNestedStructFactory : AbstractFactory<IStructNestedStruct, StructNestedStruct>
    {
        public StructNestedStructFactory(IStructNestedStruct nestedStruct)
            : base(nestedStruct)
        {
        }

        public override void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedStruct)
        {
            /*Value = new StructNestedStruct()
            {
                Attributes = nestedStruct.Attributes.ToAttributeListUsingFactory(),
                Structes = nestedStruct.Structes.ToList(@class => new NestedStructFactory(@class).Value),
                Constructors = nestedStruct.Constructors.ToList(constructor => new ConstructorFactory(constructor).Value),
                ConversionOperators = nestedStruct.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = nestedStruct.Delegates.ToList(@delegate => new NestedDelegateFactory(@delegate).Value),
                Enums = nestedStruct.Enums.ToList(@enum => new NestedEnumFactory(@enum).Value),
                EventProperties = nestedStruct.EventProperties.ToList(eventProperty => new EventPropertyFactory(eventProperty).Value),
                Events = nestedStruct.Events.ToList(@event => new EventFactory(@event).Value),
                Fields = nestedStruct.Fields.ToList(field => new FieldFactory(field).Value),
                GenericParameters = nestedStruct.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = nestedStruct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = nestedStruct.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                Interfaces = nestedStruct.Interfaces.ToList(@interface => new NestedInterfaceFactory(@interface).Value),
                IsPartial = nestedStruct.IsPartial,
                Methods = nestedStruct.Methods.ToList(method => new MethodFactory(method).Value),
                Name = nestedStruct.Name,
                OperatorOverloads = nestedStruct.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = nestedStruct.Properties.ToList(property => new PropertyFactory(property).Value),
                Structs = nestedStruct.Structs.ToList(@struct => new NestedStructFactory(@struct).Value),
                Visibility = nestedStruct.Visibility
            };*/
        }
    }
}
