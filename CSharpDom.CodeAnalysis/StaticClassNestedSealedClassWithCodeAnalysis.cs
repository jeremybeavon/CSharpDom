using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedSealedClassWithCodeAnalysis :
        AbstractStaticClassNestedSealedClass<
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
            StaticConstructorWithCodeAnalysis>
    {
        private readonly NestedSealedClassWithCodeAnalysis nestedClass;

        internal StaticClassNestedSealedClassWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedClass = new NestedSealedClassWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedClass.Attributes; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClass
        {
            get { return nestedClass.BaseClass; }
        }

        public override ClassNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return nestedClass.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithCodeAnalysis> Constructors
        {
            get { return nestedClass.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return nestedClass.ConversionOperators; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return nestedClass.Delegates; }
        }

        public override NestedDestructorWithCodeAnalysis Destructor
        {
            get { return nestedClass.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithCodeAnalysis> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override SealedClassEventCollectionWithCodeAnalysis Events
        {
            get { return nestedClass.Events; }
        }
        
        public override ClassFieldCollectionWithCodeAnalysis Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return nestedClass.ImplementedInterfaces; }
        }

        public override SealedClassIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override ClassNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override SealedClassMethodCollectionWithCodeAnalysis Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return nestedClass.OperatorOverloads; }
        }

        public override SealedClassPropertyCollectionWithCodeAnalysis Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override ClassNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return nestedClass.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
