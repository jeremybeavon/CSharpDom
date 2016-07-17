using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructFactory : AbstractFactory<IStruct, Struct>
    {
        public StructFactory(IStruct @struct)
            : base(@struct)
        {
        }

        public override void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @struct)
        {
            Value = new Struct()
            {
                Attributes = @struct.Attributes.ToAttributeListUsingFactory(),
                Classes = new StructNestedClassCollectionFactory(@struct.Classes).Value,
                Constructors = @struct.Constructors.ToList(constructor => new StructConstructorFactory(constructor).Value),
                ConversionOperators = @struct.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @struct.Delegates.ToList(@delegate => new StructNestedDelegateFactory(@delegate).Value),
                Enums = @struct.Enums.ToList(@enum => new StructNestedEnumFactory(@enum).Value),
                Events = new StructEventCollectionFactory(@struct.Events).Value,
                Fields = new StructFieldCollectionFactory(@struct.Fields).Value,
                GenericParameters = @struct.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @struct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = new StructIndexerCollectionFactory(@struct.Indexers).Value,
                Interfaces = new StructNestedInterfaceCollectionFactory(@struct.Interfaces).Value,
                Methods = new StructMethodCollectionFactory(@struct.Methods).Value,
                Name = @struct.Name,
                OperatorOverloads = @struct.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = new StructPropertyCollectionFactory(@struct.Properties).Value,
                Structs = new StructNestedStructCollectionFactory(@struct.Structs).Value,
                Visibility = @struct.Visibility
            };
            foreach (StructConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(@struct);
            }
        }
    }
}
