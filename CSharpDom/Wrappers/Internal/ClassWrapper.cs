using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassWrapper : AbstractWrapper<IClass>
    {
        public ClassWrapper(IClass @class)
            : base(@class)
        {
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
        {
            Value = new Class()
            {
                Attributes = @class.Attributes.ToAttributeListUsingWrapper(),
                BaseClass = new ClassReferenceWrapper(@class.BaseClass).Value,
                Classes = new ClassNestedClassCollectionWrapper(@class.Classes).Value,
                Constructors = @class.Constructors.ToList(constructor => new ClassConstructorWrapper(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorWrapper(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new ClassNestedDelegateWrapper(@delegate).Value),
                Destructor = new DestructorWrapper(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new ClassNestedEnumWrapper(@enum).Value),
                Events = new ClassEventCollectionWrapper(@class.Events).Value,
                Fields = new ClassFieldCollectionWrapper(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceWrapper(@interface).Value),
                Indexers = new ClassIndexerCollectionWrapper(@class.Indexers).Value,
                Interfaces = new ClassNestedInterfaceCollectionWrapper(@class.Interfaces).Value,
                Methods = new ClassMethodCollectionWrapper(@class.Methods).Value,
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadWrapper(@operator).Value),
                Properties = new ClassPropertyCollectionWrapper(@class.Properties).Value,
                Structs = new ClassNestedStructCollectionWrapper(@class.Structs).Value,
                Visibility = @class.Visibility
            };
            if (Value.Destructor != null)
            {
                Value.Destructor.AttachDeclaringType(@class);
            }
            foreach (ClassConstructor constructor in Value.Constructors)
            {
                constructor.AttachDeclaringType(@class);
            }
        }
    }
}
