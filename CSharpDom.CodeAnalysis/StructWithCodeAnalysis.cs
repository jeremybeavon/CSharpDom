﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructWithCodeAnalysis :
        EditableStruct<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
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
            StructNestedInterfaceWithCodeAnalysis,
            StructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>,
        IHasNode<StructDeclarationSyntax>,
        IStructTypeWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly DocumentWithCodeAnalysis document;

        internal StructWithCodeAnalysis(DocumentWithCodeAnalysis document, StructTypeWithCodeAnalysis type = null)
        {
            structType = type ?? new InternalStructTypeWithCodeAnalysis<StructWithCodeAnalysis>(this);
            this.document = document;
        }

        public StructTypeWithCodeAnalysis Struct
        {
            get { return structType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return structType.Attributes; }
            set { structType.Attributes = value; }
        }

        public override StructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return structType.Classes; }
            set { structType.Classes = value; }
        }

        public override ICollection<StructConstructorWithCodeAnalysis> Constructors
        {
            get { return structType.Constructors; }
            set { structType.Constructors = value; }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return structType.ConversionOperators; }
            set { structType.ConversionOperators = value; }
        }

        public override ICollection<StructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return structType.Delegates; }
            set { structType.Delegates = value; }
        }
        
        public override ICollection<StructNestedEnumWithCodeAnalysis> Enums
        {
            get { return structType.Enums; }
            set { structType.Enums = value; }
        }

        public override StructEventCollectionWithCodeAnalysis Events
        {
            get { return structType.Events; }
            set { structType.Events = value; }
        }

        public override StructFieldCollectionWithCodeAnalysis Fields
        {
            get { return structType.Fields; }
            set { structType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return structType.GenericParameters; }
            set { structType.GenericParameters = value; }
        }

        public override StructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return structType.Indexers; }
            set { structType.Indexers = value; }
        }

        public override ICollection<StructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return structType.Interfaces; }
            set { structType.Interfaces = value; }
        }

        public override StructMethodCollectionWithCodeAnalysis Methods
        {
            get { return structType.Methods; }
            set { structType.Methods = value; }
        }

        public override string Name
        {
            get { return structType.Name; }
            set { structType.Name = value; }
        }

        public override ICollection<OperatorOverloadWithCodeAnalysis> OperatorOverloads
        {
            get { return structType.OperatorOverloads; }
            set { structType.OperatorOverloads = value; }
        }

        public override StructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return structType.Properties; }
            set { structType.Properties = value; }
        }

        public override StructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return structType.Structs; }
            set { structType.Structs = value; }
        }
        
        public override ICollection<InterfaceReferenceWithCodeAnalysis> ImplementedInterfaces
        {
            get { return structType.ImplementedInterfaces; }
            set { structType.ImplementedInterfaces = value; }
        }

        public override StaticConstructorWithCodeAnalysis StaticConstructor
        {
            get { return structType.StaticConstructor; }
            set { structType.StaticConstructor = value; }
        }

        public StructDeclarationSyntax Syntax
        {
            get { return structType.Syntax; }
            set { structType.Syntax = value; }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return structType.Node.GetParent<NamespaceWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return document.Project; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return document.Solution; }
            set { throw new NotSupportedException(); }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToTypeVisibilityModifier(); }
            set
            {
                StructDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        INode<StructDeclarationSyntax> IHasNode<StructDeclarationSyntax>.Node
        {
            get { return structType.Node; }
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
