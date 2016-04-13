﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedSealedClassWithReflection :
        AbstractStructNestedSealedClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            SealedClassEventCollectionWithReflection,
            SealedClassPropertyCollectionWithReflection,
            SealedClassIndexerCollectionWithReflection,
            SealedClassMethodCollectionWithReflection,
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
            StaticConstructorWithReflection>
    {
        private readonly NestedSealedClassWithReflection nestedClass;

        internal StructNestedSealedClassWithReflection(IInternalTypeWithReflection declaringType, Type type)
        {
            nestedClass = new NestedSealedClassWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedClass.Attributes; }
        }

        public override ClassReferenceWithReflection BaseClass
        {
            get { return nestedClass.BaseClass; }
        }

        public override ClassNestedClassCollectionWithReflection Classes
        {
            get { return nestedClass.Classes; }
        }

        public override IReadOnlyCollection<ClassConstructorWithReflection> Constructors
        {
            get { return nestedClass.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return nestedClass.ConversionOperators; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return nestedClass.DeclaringType; }
        }

        public override IReadOnlyCollection<ClassNestedDelegateWithReflection> Delegates
        {
            get { return nestedClass.Delegates; }
        }

        public override NestedDestructorWithReflection Destructor
        {
            get { return nestedClass.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override SealedClassEventCollectionWithReflection Events
        {
            get { return nestedClass.Events; }
        }
        
        public override ClassFieldCollectionWithReflection Fields
        {
            get { return nestedClass.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return nestedClass.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return nestedClass.ImplementedInterfaces; }
        }

        public override SealedClassIndexerCollectionWithReflection Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override ClassNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override SealedClassMethodCollectionWithReflection Methods
        {
            get { return nestedClass.Methods; }
        }

        public override string Name
        {
            get { return nestedClass.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return nestedClass.OperatorOverloads; }
        }

        public override SealedClassPropertyCollectionWithReflection Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override ClassNestedStructCollectionWithReflection Structs
        {
            get { return nestedClass.Structs; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.StructMemberVisibility(); }
        }
    }
}