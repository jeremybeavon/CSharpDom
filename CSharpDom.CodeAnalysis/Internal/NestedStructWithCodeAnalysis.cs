using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedStructWithCodeAnalysis :
        AbstractNestedStruct<
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
            StaticConstructorWithCodeAnalysis>,
        ITypeWithCodeAnalysis
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly TypeDefinition type;
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal NestedStructWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            typeWithCodeAnalysis = new StructTypeWithCodeAnalysis(this);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return typeWithCodeAnalysis.Attributes; }
        }

        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return typeWithCodeAnalysis.Classes; }
        }

        public override IReadOnlyCollection<StructConstructorWithCodeAnalysis> Constructors
        {
            get { return typeWithCodeAnalysis.Constructors; }
        }

        public override IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return typeWithCodeAnalysis.ConversionOperators; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<StructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return typeWithCodeAnalysis.Delegates; }
        }
        
        public override IReadOnlyCollection<StructNestedEnumWithCodeAnalysis> Enums
        {
            get { return typeWithCodeAnalysis.Enums; }
        }
        
        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return typeWithCodeAnalysis.Events; }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return typeWithCodeAnalysis.Fields; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return typeWithCodeAnalysis.GenericParameters; }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return typeWithCodeAnalysis.Indexers; }
        }

        public override StructNestedInterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return typeWithCodeAnalysis.Interfaces; }
        }
        
        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return typeWithCodeAnalysis.Methods; }
        }

        public override string Name
        {
            get { return type.Name(); }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return typeWithCodeAnalysis.OperatorOverloads; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
        }
        
        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return typeWithCodeAnalysis.ImplementedInterfaces; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }
    }
}
