using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedStructFactory : AbstractFactory<IClassNestedStruct, ClassNestedStruct>
    {
        public ClassNestedStructFactory(IClassNestedStruct nestedStruct)
            : base(nestedStruct)
        {
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct)
        {
            Value = new ClassNestedStruct()
            {
                Attributes = nestedStruct.Attributes.ToAttributeListUsingFactory(),
                Classes = new StructNestedClassCollectionFactory(nestedStruct.Classes).Value,
                Constructors = nestedStruct.Constructors.ToList(constructor => new StructConstructorFactory(constructor).Value),
                ConversionOperators = nestedStruct.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = nestedStruct.Delegates.ToList(@delegate => new StructNestedDelegateFactory(@delegate).Value),
                Enums = nestedStruct.Enums.ToList(@enum => new StructNestedEnumFactory(@enum).Value),
                Events = new StructEventCollectionFactory(nestedStruct.Events).Value,
                Fields = new StructFieldCollectionFactory(nestedStruct.Fields).Value,
                GenericParameters = nestedStruct.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = nestedStruct.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = new StructIndexerCollectionFactory(nestedStruct.Indexers).Value,
                Interfaces = new StructNestedInterfaceCollectionFactory(nestedStruct.Interfaces).Value,
                Methods = new StructMethodCollectionFactory(nestedStruct.Methods).Value,
                Name = nestedStruct.Name,
                OperatorOverloads = nestedStruct.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = new StructPropertyCollectionFactory(nestedStruct.Properties).Value,
                StaticConstructor = new StaticConstructorFactory(nestedStruct.StaticConstructor).Value,
                Structs = new StructNestedStructCollectionFactory(nestedStruct.Structs).Value,
                Visibility = nestedStruct.Visibility
            };
            foreach (StructConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(nestedStruct);
            }
        }
    }
}
