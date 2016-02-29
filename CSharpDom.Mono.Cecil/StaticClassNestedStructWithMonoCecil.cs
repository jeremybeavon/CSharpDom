using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedStructWithMonoCecil :
        AbstractStaticClassNestedStruct<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            StructEventCollectionWithMonoCecil,
            StructPropertyCollectionWithMonoCecil,
            StructIndexerCollectionWithMonoCecil,
            StructMethodCollectionWithMonoCecil,
            StructFieldCollectionWithMonoCecil,
            StructConstructorWithMonoCecil,
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            StructNestedClassCollectionWithMonoCecil,
            StructNestedDelegateWithMonoCecil,
            StructNestedEnumWithMonoCecil,
            StructNestedInterfaceCollectionWithMonoCecil,
            StructNestedStructCollectionWithMonoCecil,
            StaticConstructorWithMonoCecil>
    {
        private readonly NestedStructWithMonoCecil nestedStruct;

        internal StaticClassNestedStructWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            nestedStruct = new NestedStructWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedStruct.Attributes; }
        }

        public override StructNestedClassCollectionWithMonoCecil Classes
        {
            get { return nestedStruct.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithMonoCecil> Constructors
        {
            get { return nestedStruct.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return nestedStruct.ConversionOperators; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedStruct.DeclaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithMonoCecil> Delegates
        {
            get { return nestedStruct.Delegates; }
        }

        public override IReadOnlyCollection<StructNestedEnumWithMonoCecil> Enums
        {
            get { return nestedStruct.Enums; }
        }

        public override StructEventCollectionWithMonoCecil Events
        {
            get { return nestedStruct.Events; }
        }

        public override StructFieldCollectionWithMonoCecil Fields
        {
            get { return nestedStruct.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return nestedStruct.GenericParameters; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return nestedStruct.ImplementedInterfaces; }
        }

        public override StructIndexerCollectionWithMonoCecil Indexers
        {
            get { return nestedStruct.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return nestedStruct.Interfaces; }
        }

        public override StructMethodCollectionWithMonoCecil Methods
        {
            get { return nestedStruct.Methods; }
        }

        public override string Name
        {
            get { return nestedStruct.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return nestedStruct.OperatorOverloads; }
        }

        public override StructPropertyCollectionWithMonoCecil Properties
        {
            get { return nestedStruct.Properties; }
        }

        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return nestedStruct.StaticConstructor; }
        }

        public override StructNestedStructCollectionWithMonoCecil Structs
        {
            get { return nestedStruct.Structs; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedStruct.TypeDefinition.StaticClassMemberVisibility(); }
        }
    }
}
