using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructFactory : AbstractFactory<IStruct, Struct>
    {
        public StructFactory(IStruct @struct)
            : base(@struct)
        {
        }

        public override void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
        {
            Value = new Struct()
            {
                Attributes = @struct.Attributes.ToAttributeListUsingFactory(),
                Classes = @struct.Classes.ToList(@class => new NestedClassFactory(@class).Value),
                Constructors = @struct.Constructors.ToList(constructor => new ConstructorFactory(constructor).Value),
                ConversionOperators = @struct.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @struct.Delegates.ToList(@delegate => new NestedDelegateFactory(@delegate).Value),
                Enums = @struct.Enums.ToList(@enum => new NestedEnumFactory(@enum).Value),
                EventProperties = @struct.EventProperties.ToList(eventProperty => new EventPropertyFactory(eventProperty).Value),
                Events = @struct.Events.ToList(@event => new EventFactory(@event).Value),
                Fields = @struct.Fields.ToList(field => new FieldFactory(field).Value),
                GenericParameters = @struct.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @struct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = @struct.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                Interfaces = @struct.Interfaces.ToList(@interface => new NestedInterfaceFactory(@interface).Value),
                Methods = @struct.Methods.ToList(method => new MethodFactory(method).Value),
                Name = @struct.Name,
                OperatorOverloads = @struct.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = @struct.Properties.ToList(property => new PropertyFactory(property).Value),
                Structs = @struct.Structs.ToList(nestedStruct => new NestedStructFactory(nestedStruct).Value),
                Visibility = @struct.Visibility
            };
        }
    }
}
