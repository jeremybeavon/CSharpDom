using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Mono.Cecil.Internal.Hiding;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedSealedClassWithCodeAnalysis :
        AbstractNestedSealedClass<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ClassReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            SealedClassEventCollectionWithCodeAnalysis,
            SealedClassPropertyCollectionWithCodeAnalysis,
            SealedClassIndexerCollectionWithCodeAnalysis,
            SealedClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            NestedDestructorWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis,
        IInternalTypeWithCodeAnalysis,
        IHasTypeDefinition
    {
        private readonly NestedClassWithCodeAnalysis typeWithCodeAnalysis;
        private readonly SealedTypeWithCodeAnalysis sealedTypeWithCodeAnalysis;
        private readonly SealedClassEventCollectionWithCodeAnalysis events;
        private readonly SealedClassIndexerCollectionWithCodeAnalysis indexers;
        private readonly SealedClassMethodCollectionWithCodeAnalysis methods;
        private readonly SealedClassPropertyCollectionWithCodeAnalysis properties;

        internal NestedSealedClassWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            typeWithCodeAnalysis = new NestedClassWithCodeAnalysis(declaringType, type);
            sealedTypeWithCodeAnalysis = new SealedTypeWithCodeAnalysis(this);
            events = new SealedClassEventCollectionWithCodeAnalysis(sealedTypeWithCodeAnalysis);
            indexers = new SealedClassIndexerCollectionWithCodeAnalysis(sealedTypeWithCodeAnalysis);
            methods = new SealedClassMethodCollectionWithCodeAnalysis(sealedTypeWithCodeAnalysis);
            properties = new SealedClassPropertyCollectionWithCodeAnalysis(sealedTypeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return typeWithCodeAnalysis.Attributes; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return typeWithCodeAnalysis.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return typeWithCodeAnalysis.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return typeWithCodeAnalysis.ConversionOperators; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return typeWithCodeAnalysis.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return typeWithCodeAnalysis.Delegates; }
        }

        public override NestedDestructorWithCodeAnalysis Destructor
        {
            get { return typeWithCodeAnalysis.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return typeWithCodeAnalysis.Enums; }
        }
        
        public override SealedClassEventCollectionWithCodeAnalysis Events
        {
            get { return events; }
        }

        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return typeWithCodeAnalysis.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return typeWithCodeAnalysis.GenericParameters; }
        }

        public override SealedClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return indexers; }
        }

        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return typeWithCodeAnalysis.Interfaces; }
        }
        
        public override SealedClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return methods; }
        }

        public override string Name
        {
            get { return typeWithCodeAnalysis.Name; }
        }
        
        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return typeWithCodeAnalysis.OperatorOverloads; }
        }
        
        public override SealedClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return properties; }
        }
        
        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return typeWithCodeAnalysis.BaseClass; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return typeWithCodeAnalysis.ImplementedInterfaces; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return typeWithCodeAnalysis.TypeDefinition; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public HiddenMembersAnalyzer HiddenMembersAnalyzer
        {
            get { return typeWithCodeAnalysis.HiddenMembersAnalyzer; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return typeWithCodeAnalysis.Assembly; }
        }
    }
}
