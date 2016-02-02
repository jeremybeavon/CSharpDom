using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedClassFactory : AbstractFactory<IClassNestedClass, ClassNestedClass>
    {
        public NestedClassFactory(IClassNestedClass nestedClass)
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
                Classes = nestedClass.Classes.ToList(@class => new NestedClassFactory(@class).Value),
                Constructors = nestedClass.Constructors.ToList(constructor => new ConstructorFactory(constructor).Value),
                ConversionOperators = nestedClass.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = nestedClass.Delegates.ToList(@delegate => new NestedDelegateFactory(@delegate).Value),
                Destructor = new NestedDestructorFactory(nestedClass.Destructor).Value,
                Enums = nestedClass.Enums.ToList(@enum => new NestedEnumFactory(@enum).Value),
                EventProperties = nestedClass.EventProperties.ToList(eventProperty => new EventPropertyFactory(eventProperty).Value),
                Events = nestedClass.Events.ToList(@event => new EventFactory(@event).Value),
                Fields = nestedClass.Fields.ToList(field => new FieldFactory(field).Value),
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = nestedClass.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = nestedClass.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                InheritanceModifier = nestedClass.InheritanceModifier,
                Interfaces = nestedClass.Interfaces.ToList(@interface => new NestedInterfaceFactory(@interface).Value),
                IsPartial = nestedClass.IsPartial,
                Methods = nestedClass.Methods.ToList(method => new MethodFactory(method).Value),
                Name = nestedClass.Name,
                OperatorOverloads = nestedClass.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = nestedClass.Properties.ToList(property => new PropertyFactory(property).Value),
                Structs = nestedClass.Structs.ToList(@struct => new NestedStructFactory(@struct).Value),
                Visibility = nestedClass.Visibility
            };
        }
    }
}
