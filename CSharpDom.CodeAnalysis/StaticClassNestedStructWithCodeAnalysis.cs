using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructWithCodeAnalysis :
        AbstractStaticClassNestedStruct<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            StructEventCollectionWithCodeAnalysis,
            StructPropertyCollectionWithCodeAnalysis,
            StructIndexerCollectionWithCodeAnalysis,
            StructMethodCollectionWithCodeAnalysis,
            StructFieldCollectionWithCodeAnalysis,
            StructConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            StructNestedClassCollectionWithCodeAnalysis,
            StructNestedDelegateWithCodeAnalysis,
            StructNestedEnumWithCodeAnalysis,
            StructNestedInterfaceCollectionWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>
    {
        private readonly NestedStructWithCodeAnalysis nestedStruct;

        internal StaticClassNestedStructWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedStruct = new NestedStructWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedStruct.Attributes; }
        }

        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return nestedStruct.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithCodeAnalysis> Constructors
        {
            get { return nestedStruct.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return nestedStruct.ConversionOperators; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedStruct.DeclaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return nestedStruct.Delegates; }
        }

        public override IReadOnlyCollection<StructNestedEnumWithCodeAnalysis> Enums
        {
            get { return nestedStruct.Enums; }
        }

        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return nestedStruct.Events; }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return nestedStruct.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedStruct.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return nestedStruct.ImplementedInterfaces; }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return nestedStruct.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return nestedStruct.Interfaces; }
        }

        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return nestedStruct.Methods; }
        }

        public override string Name
        {
            get { return nestedStruct.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return nestedStruct.OperatorOverloads; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return nestedStruct.Properties; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return nestedStruct.StaticConstructor; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return nestedStruct.Structs; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedStruct.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
