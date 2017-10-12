using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedAbstractClassWithReflection :
        AbstractClassNestedAbstractClass<
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
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection,
            DestructorWithReflection>,
        IClassTypeDefinitionWithReflection
    {
        private readonly NestedAbstractClassWithReflection nestedClass;

        internal ClassNestedAbstractClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedClass = new NestedAbstractClassWithReflection(declaringType, type);
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

        public override DestructorWithReflection Destructor
        {
            get { return nestedClass.Destructor; }
        }

        public override IReadOnlyCollection<ClassNestedEnumWithReflection> Enums
        {
            get { return nestedClass.Enums; }
        }
        
        public override AbstractClassEventCollectionWithReflection Events
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

        public override AbstractClassIndexerCollectionWithReflection Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override AbstractClassMethodCollectionWithReflection Methods
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

        public override AbstractClassPropertyCollectionWithReflection Properties
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.ClassMemberVisibility(); }
        }
    }
}
