﻿using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassFactory : AbstractFactory<IClass, Class>
    {
        public ClassFactory(IClass @class)
            : base(@class)
        {
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @class)
        {
            Value = new Class()
            {
                Attributes = @class.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(@class.BaseClass).Value,
                Classes = @class.Classes.ToList(nestedClass => new ClassNestedClassFactory(nestedClass).Value),
                Constructors = @class.Constructors.ToList(constructor => new ClassConstructorFactory(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new ClassNestedDelegateFactory(@delegate).Value),
                Destructor = new DestructorFactory(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new ClassNestedEnumFactory(@enum).Value),
                EventProperties = @class.EventProperties.ToList(eventProperty => new ClassEventPropertyFactory(eventProperty).Value),
                Events = @class.Events.ToList(@event => new ClassEventFactory(@event).Value),
                Fields = @class.Fields.ToList(field => new ClassFieldFactory(field).Value),
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = @class.Indexers.ToList(indexer => new ClassIndexerFactory(indexer).Value),
                Interfaces = @class.Interfaces.ToList(@interface => new ClassNestedInterfaceFactory(@interface).Value),
                Methods = @class.Methods.ToList(method => new ClassMethodFactory(method).Value),
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = @class.Properties.ToList(property => new ClassPropertyFactory(property).Value),
                Structs = @class.Structs.ToList(@struct => new ClassNestedStructFactory(@struct).Value),
                Visibility = @class.Visibility
            };
        }
    }
}
