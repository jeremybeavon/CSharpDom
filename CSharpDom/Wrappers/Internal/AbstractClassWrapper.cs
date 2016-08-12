using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractClassWrapper : AbstractWrapper<IAbstractClass>
    {
        public AbstractClassWrapper(IAbstractClass @class)
            : base(@class)
        {
        }

        public override void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
        {
            Value = new AbstractClass()
            {
                Attributes = @class.Attributes.ToAttributeListUsingWrapper(),
                BaseClass = new ClassReferenceWrapper(@class.BaseClass).Value,
                Classes = new ClassNestedClassCollectionWrapper(@class.Classes).Value,
                Constructors = @class.Constructors.ToList(constructor => new ClassConstructorWrapper(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorWrapper(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new ClassNestedDelegateWrapper(@delegate).Value),
                Destructor = new DestructorWrapper(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new ClassNestedEnumWrapper(@enum).Value),
                Events = new AbstractClassEventCollectionWrapper(@class.Events).Value,
                Fields = new ClassFieldCollectionWrapper(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceWrapper(@interface).Value),
                Indexers = new AbstractClassIndexerCollectionWrapper(@class.Indexers).Value,
                Interfaces = new ClassNestedInterfaceCollectionWrapper(@class.Interfaces).Value,
                Methods = new AbstractClassMethodCollectionWrapper(@class.Methods).Value,
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadWrapper(@operator).Value),
                Properties = new AbstractClassPropertyCollectionWrapper(@class.Properties).Value,
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
