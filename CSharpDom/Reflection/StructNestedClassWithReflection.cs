using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedClassWithReflection :
        AbstractStructNestedClass<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ClassReferenceWithReflection,
            InterfaceReferenceWithReflection,
            ClassEventWithReflection,
            ClassPropertyWithReflection,
            ClassIndexerWithReflection,
            ClassMethodWithReflection,
            ClassFieldWithReflection,
            ClassConstructorWithReflection,
            ClassEventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceWithReflection,
            ClassNestedStructWithReflection,
            NestedDestructorWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly NestedClassWithReflection nestedClass;

        internal StructNestedClassWithReflection(ITypeWithReflection declaringType, Type type)
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

        public override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
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

        public override IReadOnlyCollection<ClassEventPropertyWithReflection> EventProperties
        {
            get { return nestedClass.EventProperties; }
        }

        public override IReadOnlyCollection<ClassEventWithReflection> Events
        {
            get { return nestedClass.Events; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return nestedClass.ExplicitInterfaceEvents; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return nestedClass.ExplicitInterfaceIndexers; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return nestedClass.ExplicitInterfaceMethods; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return nestedClass.ExplicitInterfaceProperties; }
        }

        public override IReadOnlyCollection<ClassFieldWithReflection> Fields
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

        public override IReadOnlyCollection<ClassIndexerWithReflection> Indexers
        {
            get { return nestedClass.Indexers; }
        }
        
        public override IReadOnlyCollection<ClassNestedInterfaceWithReflection> Interfaces
        {
            get { return nestedClass.Interfaces; }
        }
        
        public override IReadOnlyCollection<ClassMethodWithReflection> Methods
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

        public override IReadOnlyCollection<ClassPropertyWithReflection> Properties
        {
            get { return nestedClass.Properties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return nestedClass.StaticConstructor; }
        }

        public override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get { return nestedClass.Structs; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedClass.Type.StructMemberVisibility(); }
        }
    }
}
