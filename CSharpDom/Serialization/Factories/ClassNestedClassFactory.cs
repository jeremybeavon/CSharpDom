using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedClassFactory : AbstractFactory<IClassNestedClass, ClassNestedClass>
    {
        public ClassNestedClassFactory(IClassNestedClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedClass)
        {
            Value = new ClassNestedClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(nestedClass.BaseClass).Value,
                Classes = nestedClass.Classes.ToList(@class => new ClassNestedClassFactory(@class).Value),
                Constructors = nestedClass.Constructors.ToList(constructor => new ClassConstructorFactory(constructor).Value),
                ConversionOperators = nestedClass.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = nestedClass.Delegates.ToList(@delegate => new ClassNestedDelegateFactory(@delegate).Value),
                Destructor = new NestedDestructorFactory(nestedClass.Destructor).Value,
                Enums = nestedClass.Enums.ToList(@enum => new ClassNestedEnumFactory(@enum).Value),
                EventProperties = nestedClass.EventProperties.ToList(eventProperty => new ClassEventPropertyFactory(eventProperty).Value),
                Events = nestedClass.Events.ToList(@event => new ClassEventFactory(@event).Value),
                Fields = nestedClass.Fields.ToList(field => new ClassFieldFactory(field).Value),
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = nestedClass.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = nestedClass.Indexers.ToList(indexer => new ClassIndexerFactory(indexer).Value),
                Interfaces = nestedClass.Interfaces.ToList(@interface => new ClassNestedInterfaceFactory(@interface).Value),
                Methods = nestedClass.Methods.ToList(method => new ClassMethodFactory(method).Value),
                Name = nestedClass.Name,
                OperatorOverloads = nestedClass.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = nestedClass.Properties.ToList(property => new ClassPropertyFactory(property).Value),
                Structs = nestedClass.Structs.ToList(@struct => new ClassNestedStructFactory(@struct).Value),
                Visibility = nestedClass.Visibility
            };
        }
    }
}
