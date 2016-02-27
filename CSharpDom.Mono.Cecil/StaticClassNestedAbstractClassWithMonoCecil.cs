using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedAbstractClassWithMonoCecil :
        AbstractStaticClassNestedAbstractClass<
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
            StaticConstructorWithMonoCecil>
    {
        private readonly NestedAbstractClassWithMonoCecil nestedClass;

        internal StaticClassNestedAbstractClassWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            nestedClass = new NestedAbstractClassWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedClass.Attributes; }
        }

        public override ClassReferenceWithMonoCecil BaseClass
        {
            get { return nestedClass.BaseClass; }
        }

        public override ClassNestedClassCollectionWithMonoCecil Classes
        {
            get { return nestedClass.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithMonoCecil> Constructors
        {
            get { return nestedClass.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return nestedClass.ConversionOperators; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithMonoCecil> Delegates
        {
            get { return nestedClass.Delegates; }
        }

        public override NestedDestructorWithMonoCecil Destructor
        {
            get { return nestedClass.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithMonoCecil> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override AbstractClassEventCollectionWithMonoCecil Events
        {
            get { return nestedClass.Events; }
        }
        
        public override ClassFieldCollectionWithMonoCecil Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return nestedClass.ImplementedInterfaces; }
        }

        public override AbstractClassIndexerCollectionWithMonoCecil Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override ClassNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override AbstractClassMethodCollectionWithMonoCecil Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return nestedClass.OperatorOverloads; }
        }

        public override AbstractClassPropertyCollectionWithMonoCecil Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override ClassNestedStructCollectionWithMonoCecil Structs
        {
            get { return nestedClass.Structs; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.StaticClassMemberVisibility(); }
        }
    }
}
