using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedStructWithReflection :
        AbstractStructNestedStruct<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            StructEventCollectionWithReflection,
            StructPropertyCollectionWithReflection,
            StructIndexerCollectionWithReflection,
            StructMethodCollectionWithReflection,
            StructFieldCollectionWithReflection,
            StructConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            StructNestedClassCollectionWithReflection,
            StructNestedDelegateWithReflection,
            StructNestedEnumWithReflection,
            StructNestedInterfaceCollectionWithReflection,
            StructNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>
    {
        private readonly NestedStructWithReflection nestedStruct;

        internal StructNestedStructWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedStruct = new NestedStructWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedStruct.Attributes; }
        }

        public override StructNestedClassCollectionWithReflection Classes
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

        public override StructEventCollectionWithReflection Events
        {
            get { return nestedStruct.Events; }
        }

        public override StructFieldCollectionWithReflection Fields
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

        public override StructIndexerCollectionWithReflection Indexers
        {
            get { return nestedStruct.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithReflection Interfaces
        {
            get { return nestedStruct.Interfaces; }
        }

        public override StructMethodCollectionWithReflection Methods
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

        public override StructPropertyCollectionWithReflection Properties
        {
            get { return nestedStruct.Properties; }
        }

        public override StaticConstructorWithReflection StaticConstructor
        {
            get { return nestedStruct.StaticConstructor; }
        }

        public override StructNestedStructCollectionWithReflection Structs
        {
            get { return nestedStruct.Structs; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedStruct.Type.StructMemberVisibility(); }
        }
    }
}
