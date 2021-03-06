﻿using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractClassFactory : AbstractFactory<IAbstractClass, AbstractClass>
    {
        public AbstractClassFactory(IAbstractClass @class)
            : base(@class)
        {
        }

        public override void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            Value = new AbstractClass()
            {
                Attributes = @class.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(@class.BaseClass).Value,
                Classes = new ClassNestedClassCollectionFactory(@class.Classes).Value,
                Constructors = @class.Constructors.ToList(constructor => new ClassConstructorFactory(constructor).Value),
                ConversionOperators = @class.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = @class.Delegates.ToList(@delegate => new ClassNestedDelegateFactory(@delegate).Value),
                Destructor = new DestructorFactory(@class.Destructor).Value,
                Enums = @class.Enums.ToList(@enum => new ClassNestedEnumFactory(@enum).Value),
                Events = new AbstractClassEventCollectionFactory(@class.Events).Value,
                Fields = new ClassFieldCollectionFactory(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = @class.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = new AbstractClassIndexerCollectionFactory(@class.Indexers).Value,
                Interfaces = @class.Interfaces.ToList(@interface => new ClassNestedInterfaceFactory(@interface).Value),
                Methods = new AbstractClassMethodCollectionFactory(@class.Methods).Value,
                Name = @class.Name,
                OperatorOverloads = @class.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = new AbstractClassPropertyCollectionFactory(@class.Properties).Value,
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
