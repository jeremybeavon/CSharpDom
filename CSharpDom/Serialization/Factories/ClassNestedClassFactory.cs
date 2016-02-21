﻿using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedClassFactory : AbstractFactory<IClassNestedClass, ClassNestedClass>
    {
        public ClassNestedClassFactory(IClassNestedClass nestedClass)
            : base(nestedClass)
        {
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass)
        {
            Value = new ClassNestedClass()
            {
                Attributes = nestedClass.Attributes.ToAttributeListUsingFactory(),
                BaseClass = new ClassReferenceFactory(nestedClass.BaseClass).Value,
                Classes = new ClassNestedClassCollectionFactory(nestedClass.Classes).Value,
                Constructors = nestedClass.Constructors.ToList(constructor => new ClassConstructorFactory(constructor).Value),
                ConversionOperators = nestedClass.ConversionOperators.ToList(@operator => new ConversionOperatorFactory(@operator).Value),
                Delegates = nestedClass.Delegates.ToList(@delegate => new ClassNestedDelegateFactory(@delegate).Value),
                Destructor = new NestedDestructorFactory(nestedClass.Destructor).Value,
                Enums = nestedClass.Enums.ToList(@enum => new ClassNestedEnumFactory(@enum).Value),
                Events = new ClassEventCollectionFactory(nestedClass.Events).Value,
                Fields = new ClassFieldCollectionFactory(nestedClass.Fields).Value,
                GenericParameters = nestedClass.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                ImplementedInterfaces = nestedClass.ImplementedInterfaces.ToList(@interface => new InterfaceReferenceFactory(@interface).Value),
                Indexers = new ClassIndexerCollectionFactory(nestedClass.Indexers).Value,
                Interfaces = new ClassNestedInterfaceCollectionFactory(nestedClass.Interfaces).Value,
                Methods = new ClassMethodCollectionFactory(nestedClass.Methods).Value,
                Name = nestedClass.Name,
                OperatorOverloads = nestedClass.OperatorOverloads.ToList(@operator => new OperatorOverloadFactory(@operator).Value),
                Properties = new ClassPropertyCollectionFactory(nestedClass.Properties).Value,
                Structs = new ClassNestedStructCollectionFactory(nestedClass.Structs).Value,
                Visibility = nestedClass.Visibility
            };
        }
    }
}
