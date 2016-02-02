using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassFactory : AbstractFactory<IClass, Class>
    {
        public ClassFactory(IClass @class)
            : base(@class)
        {
        }

        public override void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @class)
        {
            Value = new Class()
            {
                Attributes = @class.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(@class.BaseClass).Value,
                Classes = @class.Classes.ToList(nestedClass => new NestedClassFactory(nestedClass).Value),
                Constructors = @class.Constructors.ToList(constructor => new ConstructorFactory(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new NestedDelegateFactory(@delegate).Value),
                Destructor = new DestructorFactory(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new NestedEnumFactory(@enum).Value),
                EventProperties = @class.EventProperties.ToList(eventProperty => new EventPropertyFactory(eventProperty).Value),
                Events = @class.Events.ToList(@event => new EventFactory(@event).Value),
                Fields = @class.Fields.ToList(field => new FieldFactory(field).Value),
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = @class.Indexers.ToList(indexer => new IndexerFactory(indexer).Value),
                InheritanceModifier = @class.InheritanceModifier,
                Interfaces = @class.Interfaces.ToList(@interface => new NestedInterfaceFactory(@interface).Value),
                IsPartial = @class.IsPartial,
                Methods = @class.Methods.ToList(method => new MethodFactory(method).Value),
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = @class.Properties.ToList(property => new PropertyFactory(property).Value),
                Structs = @class.Structs.ToList(@struct => new NestedStructFactory(@struct).Value),
                Visibility = @class.Visibility
            };
        }
    }
}
