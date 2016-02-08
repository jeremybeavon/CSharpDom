using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedStructWithReflection :
        AbstractClassNestedStruct<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            StructEventWithReflection,
            StructPropertyWithReflection,
            StructIndexerWithReflection,
            StructMethodWithReflection,
            StructFieldWithReflection,
            StructConstructorWithReflection,
            StructEventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            StructNestedClassWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceWithReflection,
            StructNestedStructWithReflection,
            StaticConstructorWithReflection,
            ExplicitInterfaceEventWithReflection,
            ExplicitInterfacePropertyWithReflection,
            ExplicitInterfaceIndexerWithReflection,
            ExplicitInterfaceMethodWithReflection>
    {
        private readonly NestedStructWithReflection nestedStruct;

        internal ClassNestedStructWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedStruct = new NestedStructWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedStruct.Attributes; }
        }

        public override IReadOnlyCollection<StructNestedClassWithReflection> Classes
        {
            get { return nestedStruct.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithReflection> Constructors
        {
            get { return nestedStruct.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperators
        {
            get { return nestedStruct.ConversionOperators; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return nestedStruct.DeclaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithReflection> Delegates
        {
            get { return nestedStruct.Delegates; }
        }

        public override IReadOnlyCollection<StructNestedEnumWithReflection> Enums
        {
            get { return nestedStruct.Enums; }
        }

        public override IReadOnlyCollection<StructEventPropertyWithReflection> EventProperties
        {
            get { return nestedStruct.EventProperties; }
        }

        public override IReadOnlyCollection<StructEventWithReflection> Events
        {
            get { return nestedStruct.Events; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceEventWithReflection> ExplicitInterfaceEvents
        {
            get { return nestedStruct.ExplicitInterfaceEvents; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return nestedStruct.ExplicitInterfaceIndexers; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethods
        {
            get { return nestedStruct.ExplicitInterfaceMethods; }
        }

        public override IReadOnlyCollection<ExplicitInterfacePropertyWithReflection> ExplicitInterfaceProperties
        {
            get { return nestedStruct.ExplicitInterfaceProperties; }
        }

        public override IReadOnlyCollection<StructFieldWithReflection> Fields
        {
            get { return nestedStruct.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return nestedStruct.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> ImplementedInterfaces
        {
            get { return nestedStruct.ImplementedInterfaces; }
        }

        public override IReadOnlyCollection<StructIndexerWithReflection> Indexers
        {
            get { return nestedStruct.Indexers; }
        }

        public override IReadOnlyCollection<StructNestedInterfaceWithReflection> Interfaces
        {
            get { return nestedStruct.Interfaces; }
        }
        
        public override IReadOnlyCollection<StructMethodWithReflection> Methods
        {
            get { return nestedStruct.Methods; }
        }

        public override string Name
        {
            get { return nestedStruct.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloads
        {
            get { return nestedStruct.OperatorOverloads; }
        }

        public override IReadOnlyCollection<StructPropertyWithReflection> Properties
        {
            get { return nestedStruct.Properties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return nestedStruct.StaticConstructor; }
        }

        public override IReadOnlyCollection<StructNestedStructWithReflection> Structs
        {
            get { return nestedStruct.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedStruct.Type.ClassMemberVisibility(); }
        }
    }
}
