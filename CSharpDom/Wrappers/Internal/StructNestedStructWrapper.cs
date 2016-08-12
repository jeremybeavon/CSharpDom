using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedStructWrapper : AbstractWrapper<IStructNestedStruct>
    {
        public StructNestedStructWrapper(IStructNestedStruct nestedStruct)
            : base(nestedStruct)
        {
        }

        public override void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Value = new StructNestedStruct()
            {
                Attributes = nestedStruct.Attributes.ToAttributeListUsingWrapper(),
                Classes = new StructNestedClassCollectionWrapper(nestedStruct.Classes).Value,
                Constructors = nestedStruct.Constructors.ToList(constructor => new StructConstructorWrapper(constructor).Value),
                ConversionOperators = nestedStruct.ConversionOperators.ToList(@operator => new ConversionOperatorWrapper(@operator).Value),
                Delegates = nestedStruct.Delegates.ToList(@delegate => new StructNestedDelegateWrapper(@delegate).Value),
                Enums = nestedStruct.Enums.ToList(@enum => new StructNestedEnumWrapper(@enum).Value),
                Events = new StructEventCollectionWrapper(nestedStruct.Events).Value,
                Fields = new StructFieldCollectionWrapper(nestedStruct.Fields).Value,
                GenericParameters = nestedStruct.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                ImplementedInterfaces = nestedStruct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceWrapper(@interface).Value),
                Indexers = new StructIndexerCollectionWrapper(nestedStruct.Indexers).Value,
                Interfaces = new StructNestedInterfaceCollectionWrapper(nestedStruct.Interfaces).Value,
                Methods = new StructMethodCollectionWrapper(nestedStruct.Methods).Value,
                Name = nestedStruct.Name,
                OperatorOverloads = nestedStruct.OperatorOverloads.ToList(@operator => new OperatorOverloadWrapper(@operator).Value),
                Properties = new StructPropertyCollectionWrapper(nestedStruct.Properties).Value,
                Structs = new StructNestedStructCollectionWrapper(nestedStruct.Structs).Value,
                StaticConstructor = new StaticConstructorWrapper(nestedStruct.StaticConstructor).Value,
                Visibility = nestedStruct.Visibility
            };
            foreach (StructConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(nestedStruct);
            }
        }
    }
}
