using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructWrapper : AbstractWrapper<IStruct>
    {
        public StructWrapper(IStruct @struct)
            : base(@struct)
        {
        }

        public override void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @struct)
        {
            Value = new Struct()
            {
                Attributes = @struct.Attributes.ToAttributeListUsingWrapper(),
                Classes = new StructNestedClassCollectionWrapper(@struct.Classes).Value,
                Constructors = @struct.Constructors.ToList(constructor => new StructConstructorWrapper(constructor).Value),
                ConversionOperators = @struct.ConversionOperators.ToList(@operator => new ConversionOperatorWrapper(@operator).Value),
                Delegates = @struct.Delegates.ToList(@delegate => new StructNestedDelegateWrapper(@delegate).Value),
                Enums = @struct.Enums.ToList(@enum => new StructNestedEnumWrapper(@enum).Value),
                Events = new StructEventCollectionWrapper(@struct.Events).Value,
                Fields = new StructFieldCollectionWrapper(@struct.Fields).Value,
                GenericParameters = @struct.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                ImplementedInterfaces = @struct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceWrapper(@interface).Value),
                Indexers = new StructIndexerCollectionWrapper(@struct.Indexers).Value,
                Interfaces = new StructNestedInterfaceCollectionWrapper(@struct.Interfaces).Value,
                Methods = new StructMethodCollectionWrapper(@struct.Methods).Value,
                Name = @struct.Name,
                OperatorOverloads = @struct.OperatorOverloads.ToList(@operator => new OperatorOverloadWrapper(@operator).Value),
                Properties = new StructPropertyCollectionWrapper(@struct.Properties).Value,
                Structs = new StructNestedStructCollectionWrapper(@struct.Structs).Value,
                Visibility = @struct.Visibility
            };
            foreach (StructConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(@struct);
            }
        }
    }
}
