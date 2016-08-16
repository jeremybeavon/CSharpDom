using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructWithCodeAnalysis :
        AbstractStruct<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
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
        ITypeWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
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

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return @namespace; }
        }

        public override IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return typeWithCodeAnalysis.OperatorOverloads; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return typeWithCodeAnalysis.Properties; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return assembly; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return typeWithCodeAnalysis.Structs; }
        }
        
        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return typeWithCodeAnalysis.ImplementedInterfaces; }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public override bool IsPartial
        {
            get { return false; }
        }
        
        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return typeWithCodeAnalysis.StaticConstructor; }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return assembly; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitStructWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
