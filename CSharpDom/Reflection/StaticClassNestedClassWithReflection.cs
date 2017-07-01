using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedClassWithReflection :
        AbstractStaticClassNestedClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            ClassEventCollectionWithReflection,
            ClassPropertyCollectionWithReflection,
            ClassIndexerCollectionWithReflection,
            ClassMethodCollectionWithReflection,
            ClassFieldCollectionWithReflection,
            ClassConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            NestedDestructorWithReflection,
            StaticConstructorWithReflection>
    {
        private readonly NestedClassWithReflection nestedClass;

        internal StaticClassNestedClassWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedClass = new NestedClassWithReflection(declaringType, type);
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
        
        public override ClassEventCollectionWithReflection Events
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

        public override ClassIndexerCollectionWithReflection Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override ClassMethodCollectionWithReflection Methods
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

        public override ClassPropertyCollectionWithReflection Properties
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
