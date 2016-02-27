using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassFactory : AbstractFactory<IClass, Class>
    {
        public ClassFactory(IClass @class)
            : base(@class)
        {
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
        {
            Value = new Class()
            {
                Attributes = @class.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(@class.BaseClass).Value,
                Classes = new ClassNestedClassCollectionFactory(@class.Classes).Value,
                Constructors = @class.Constructors.ToList(constructor => new ClassConstructorFactory(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new ClassNestedDelegateFactory(@delegate).Value),
                Destructor = new DestructorFactory(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new ClassNestedEnumFactory(@enum).Value),
                Events = new ClassEventCollectionFactory(@class.Events).Value,
                Fields = new ClassFieldCollectionFactory(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = new ClassIndexerCollectionFactory(@class.Indexers).Value,
                Interfaces = new ClassNestedInterfaceCollectionFactory(@class.Interfaces).Value,
                Methods = new ClassMethodCollectionFactory(@class.Methods).Value,
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = new ClassPropertyCollectionFactory(@class.Properties).Value,
                Structs = new ClassNestedStructCollectionFactory(@class.Structs).Value,
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
