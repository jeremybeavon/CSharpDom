using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedSealedClassWrapper : AbstractWrapper<IStructNestedSealedClass>
    {
        public StructNestedSealedClassWrapper(IStructNestedSealedClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
            Value = new StructNestedSealedClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingWrapper(),
                BaseClass = new ClassReferenceWrapper(nestedClass.BaseClass).Value,
                Classes = new ClassNestedClassCollectionWrapper(nestedClass.Classes).Value,
                Constructors = nestedClass.Constructors.ToList(constructor => new ClassConstructorWrapper(constructor).Value),
                ConversionOperators = nestedClass.ConversionOperators.ToList(@operator => new ConversionOperatorWrapper(@operator).Value),
                Delegates = nestedClass.Delegates.ToList(@delegate => new ClassNestedDelegateWrapper(@delegate).Value),
                Destructor = new NestedDestructorWrapper(nestedClass.Destructor).Value,
                Enums = nestedClass.Enums.ToList(@enum => new ClassNestedEnumWrapper(@enum).Value),
                Events = new SealedClassEventCollectionWrapper(nestedClass.Events).Value,
                Fields = new ClassFieldCollectionWrapper(nestedClass.Fields).Value,
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                ImplementedInterfaces = nestedClass.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceWrapper(@interface).Value),
                Indexers = new SealedClassIndexerCollectionWrapper(nestedClass.Indexers).Value,
                Interfaces = new ClassNestedInterfaceCollectionWrapper(nestedClass.Interfaces).Value,
                Methods = new SealedClassMethodCollectionWrapper(nestedClass.Methods).Value,
                Name = nestedClass.Name,
                OperatorOverloads = nestedClass.OperatorOverloads.ToList(@operator => new OperatorOverloadWrapper(@operator).Value),
                Properties = new SealedClassPropertyCollectionWrapper(nestedClass.Properties).Value,
                Structs = new ClassNestedStructCollectionWrapper(nestedClass.Structs).Value,
                Visibility = nestedClass.Visibility
            };
            if (Value.Destructor != null)
            {
                Value.Destructor.AttachDeclaringType(nestedClass);
            }
            foreach (ClassConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(nestedClass);
            }
        }
    }
}
