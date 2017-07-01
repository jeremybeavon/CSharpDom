using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedSealedClassWithMonoCecil :
        AbstractNestedSealedClass<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ClassReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            SealedClassEventCollectionWithMonoCecil,
            SealedClassPropertyCollectionWithMonoCecil,
            SealedClassIndexerCollectionWithMonoCecil,
            SealedClassMethodCollectionWithMonoCecil,
            ClassFieldCollectionWithMonoCecil,
            ClassConstructorWithMonoCecil,
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            ClassNestedClassCollectionWithMonoCecil,
            ClassNestedDelegateWithMonoCecil,
            ClassNestedEnumWithMonoCecil,
            ClassNestedInterfaceWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            NestedDestructorWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil,
        IInternalTypeWithMonoCecil,
        IHasTypeDefinition
    {
        private readonly NestedClassWithMonoCecil typeWithMonoCecil;
        private readonly SealedTypeWithMonoCecil sealedTypeWithMonoCecil;
        private readonly SealedClassEventCollectionWithMonoCecil events;
        private readonly SealedClassIndexerCollectionWithMonoCecil indexers;
        private readonly SealedClassMethodCollectionWithMonoCecil methods;
        private readonly SealedClassPropertyCollectionWithMonoCecil properties;

        internal NestedSealedClassWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            typeWithMonoCecil = new NestedClassWithMonoCecil(declaringType, type);
            sealedTypeWithMonoCecil = new SealedTypeWithMonoCecil(this);
            events = new SealedClassEventCollectionWithMonoCecil(sealedTypeWithMonoCecil);
            indexers = new SealedClassIndexerCollectionWithMonoCecil(sealedTypeWithMonoCecil);
            methods = new SealedClassMethodCollectionWithMonoCecil(sealedTypeWithMonoCecil);
            properties = new SealedClassPropertyCollectionWithMonoCecil(sealedTypeWithMonoCecil);
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
        
        public override SealedClassEventCollectionWithMonoCecil Events
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

        public override SealedClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return indexers; }
        }

        public override IReadOnlyCollection<ClassNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }
        
        public override SealedClassMethodCollectionWithMonoCecil Methods
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
        
        public override SealedClassPropertyCollectionWithMonoCecil Properties
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
        
        public TypeDefinition TypeDefinition
        {
            get { return typeWithMonoCecil.TypeDefinition; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return typeWithMonoCecil.HiddenMembersAnalyzer; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return typeWithMonoCecil.Assembly; }
        }
    }
}
