using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedStructWithMonoCecil :
        AbstractNestedStruct<
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
            StaticConstructorWithMonoCecil>,
        ITypeWithMonoCecil
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly TypeDefinition type;
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal NestedStructWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            typeWithMonoCecil = new StructTypeWithMonoCecil(this);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return typeWithMonoCecil.Attributes; }
        }

        public override StructNestedClassCollectionWithMonoCecil Classes
        {
            get { return typeWithMonoCecil.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithMonoCecil> Constructors
        {
            get { return typeWithMonoCecil.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperators
        {
            get { return typeWithMonoCecil.ConversionOperators; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithMonoCecil> Delegates
        {
            get { return typeWithMonoCecil.Delegates; }
        }
        
        public override IReadOnlyCollection<StructNestedEnumWithMonoCecil> Enums
        {
            get { return typeWithMonoCecil.Enums; }
        }
        
        public override StructEventCollectionWithMonoCecil Events
        {
            get { return typeWithMonoCecil.Events; }
        }

        public override StructFieldCollectionWithMonoCecil Fields
        {
            get { return typeWithMonoCecil.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return typeWithMonoCecil.GenericParameters; }
        }

        public override StructIndexerCollectionWithMonoCecil Indexers
        {
            get { return typeWithMonoCecil.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithMonoCecil Interfaces
        {
            get { return typeWithMonoCecil.Interfaces; }
        }
        
        public override StructMethodCollectionWithMonoCecil Methods
        {
            get { return typeWithMonoCecil.Methods; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloads
        {
            get { return typeWithMonoCecil.OperatorOverloads; }
        }

        public override StructPropertyCollectionWithMonoCecil Properties
        {
            get { return typeWithMonoCecil.Properties; }
        }

        public override StructNestedStructCollectionWithMonoCecil Structs
        {
            get { return typeWithMonoCecil.Structs; }
        }
        
        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> ImplementedInterfaces
        {
            get { return typeWithMonoCecil.ImplementedInterfaces; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithMonoCecil StaticConstructor
        {
            get { return typeWithMonoCecil.StaticConstructor; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return declaringType.Assembly; }
        }
    }
}
