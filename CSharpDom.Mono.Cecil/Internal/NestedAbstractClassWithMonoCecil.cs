using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedAbstractClassWithMonoCecil :
        AbstractNestedAbstractClass<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ClassReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            AbstractClassEventCollectionWithMonoCecil,
            AbstractClassPropertyCollectionWithMonoCecil,
            AbstractClassIndexerCollectionWithMonoCecil,
            AbstractClassMethodCollectionWithMonoCecil,
            ClassFieldCollectionWithMonoCecil,
            ClassConstructorWithMonoCecil,
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            ClassNestedClassCollectionWithMonoCecil,
            ClassNestedDelegateWithMonoCecil,
            ClassNestedEnumWithMonoCecil,
            ClassNestedInterfaceCollectionWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            NestedDestructorWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IInternalTypeWithMonoCecil,
        IHasType
    {
        private readonly NestedClassWithMonoCecil typeWithMonoCecil;
        private readonly AbstractClassEventCollectionWithMonoCecil events;
        private readonly AbstractClassIndexerCollectionWithMonoCecil indexers;
        private readonly AbstractClassMethodCollectionWithMonoCecil methods;
        private readonly AbstractClassPropertyCollectionWithMonoCecil properties;

        internal NestedAbstractClassWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            typeWithMonoCecil = new NestedClassWithMonoCecil(declaringType, type);
            events = new AbstractClassEventCollectionWithMonoCecil(typeWithMonoCecil.TypeWithMonoCecil);
            indexers = new AbstractClassIndexerCollectionWithMonoCecil(typeWithMonoCecil.TypeWithMonoCecil);
            methods = new AbstractClassMethodCollectionWithMonoCecil(typeWithMonoCecil.TypeWithMonoCecil);
            properties = new AbstractClassPropertyCollectionWithMonoCecil(typeWithMonoCecil.TypeWithMonoCecil);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return typeWithMonoCecil.Attributes; }
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return typeWithMonoCecil.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithMonoCecil> Constructors
        {
            get { return typeWithMonoCecil.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return typeWithMonoCecil.ConversionOperators; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return typeWithMonoCecil.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return typeWithMonoCecil.Delegates; }
        }

        public override NestedDestructorWithMonoCecil Destructor
        {
            get { return typeWithMonoCecil.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithMonoCecil> Enums
        {
            get { return typeWithMonoCecil.Enums; }
        }
        
        public override AbstractClassEventCollectionWithMonoCecil Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return typeWithMonoCecil.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return typeWithMonoCecil.GenericParameters; }
        }

        public override AbstractClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }
        
        public override AbstractClassMethodCollectionWithMonoCecil Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return typeWithMonoCecil.Name; }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return typeWithMonoCecil.OperatorOverloads; }
        }
        
        public override AbstractClassPropertyCollectionWithMonoCecil Properties
        {
            get { return properties; }
        }
        
        public override ClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return typeWithMonoCecil.Structs; }
        }

        public override ClassReferenceWithMonoCecil BaseClass
        {
            get { return typeWithMonoCecil.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return typeWithMonoCecil.ImplementedInterfaces; }
        }
        
        public Type Type
        {
            get { return typeWithMonoCecil.Type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return typeWithMonoCecil.HiddenMembersAnalyzer; }
        }
    }
}
