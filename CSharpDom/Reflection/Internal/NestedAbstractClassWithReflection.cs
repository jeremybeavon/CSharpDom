using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Internal.Hiding;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedAbstractClassWithReflection :
        AbstractNestedAbstractClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            AbstractClassEventCollectionWithReflection,
            AbstractClassPropertyCollectionWithReflection,
            AbstractClassIndexerCollectionWithReflection,
            AbstractClassMethodCollectionWithReflection,
            ClassFieldCollectionWithReflection,
            ClassConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceCollectionWithReflection,
            ClassNestedStructCollectionWithReflection,
            NestedDestructorWithReflection,
            StaticConstructorWithReflection>,
        ITypeWithReflection,
        IInternalTypeWithReflection,
        IHasType
    {
        private readonly NestedClassWithReflection typeWithReflection;
        private readonly AbstractClassEventCollectionWithReflection events;
        private readonly AbstractClassIndexerCollectionWithReflection indexers;
        private readonly AbstractClassMethodCollectionWithReflection methods;
        private readonly AbstractClassPropertyCollectionWithReflection properties;

        internal NestedAbstractClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            typeWithReflection = new NestedClassWithReflection(declaringType, type);
            events = new AbstractClassEventCollectionWithReflection(typeWithReflection.TypeWithReflection);
            indexers = new AbstractClassIndexerCollectionWithReflection(typeWithReflection.TypeWithReflection);
            methods = new AbstractClassMethodCollectionWithReflection(typeWithReflection.TypeWithReflection);
            properties = new AbstractClassPropertyCollectionWithReflection(typeWithReflection.TypeWithReflection);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return typeWithReflection.Attributes; }
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return typeWithReflection.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithReflection> Constructors
        {
            get { return typeWithReflection.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return typeWithReflection.ConversionOperators; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return typeWithReflection.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithReflection> Delegates
        {
            get { return typeWithReflection.Delegates; }
        }

        public override NestedDestructorWithReflection Destructor
        {
            get { return typeWithReflection.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get { return typeWithReflection.Enums; }
        }
        
        public override AbstractClassEventCollectionWithReflection Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithReflection Fields
        {
            get { return typeWithReflection.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return typeWithReflection.GenericParameters; }
        }

        public override AbstractClassIndexerCollectionWithReflection Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return typeWithReflection.Interfaces; }
        }
        
        public override AbstractClassMethodCollectionWithReflection Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return typeWithReflection.Name; }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return typeWithReflection.OperatorOverloads; }
        }
        
        public override AbstractClassPropertyCollectionWithReflection Properties
        {
            get { return properties; }
        }
        
        public override ClassNestedStructCollectionWithReflection Structs
        {
            get { return typeWithReflection.Structs; }
        }

        public override ClassReferenceWithReflection BaseClass
        {
            get { return typeWithReflection.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return typeWithReflection.ImplementedInterfaces; }
        }
        
        public Type Type
        {
            get { return typeWithReflection.Type; }
        }
        
        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return typeWithReflection.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return typeWithReflection.HiddenMembersAnalyzer; }
        }
    }
}
