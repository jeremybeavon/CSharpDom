using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructWithCodeAnalysis :
        EditablePartialStruct<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            PartialStructEventCollectionWithCodeAnalysis,
            PartialStructPropertyCollectionWithCodeAnalysis,
            PartialStructIndexerCollectionWithCodeAnalysis,
            PartialStructMethodCollectionWithCodeAnalysis,
            PartialStructFieldCollectionWithCodeAnalysis,
            PartialStructConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            PartialStructNestedClassCollectionWithCodeAnalysis,
            PartialStructNestedDelegateWithCodeAnalysis,
            PartialStructNestedEnumWithCodeAnalysis,
            PartialStructNestedInterfaceWithCodeAnalysis,
            PartialStructNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IHasSyntax<StructDeclarationSyntax>,
        IHasNode<StructDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly StructWithCodeAnalysis structType;
        private readonly PartialStructTypeWithCodeAnalysis<PartialStructWithCodeAnalysis> partialType;

        public PartialStructWithCodeAnalysis(
            DocumentWithCodeAnalysis document,
            TypeVisibilityModifier visibility,
            string name)
            : this(document)
        {
            Syntax = StructDeclarationSyntaxExtensions.ToSyntax(name, visibility, SyntaxKind.PartialKeyword);
        }

        internal PartialStructWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            var type = new InternalStructTypeWithCodeAnalysis<PartialStructWithCodeAnalysis>(this);
            structType = new StructWithCodeAnalysis(document, type);
            partialType = new PartialStructTypeWithCodeAnalysis<PartialStructWithCodeAnalysis>(type);
        }

        public StructWithCodeAnalysis Struct
        {
            get { return structType; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return structType.Attributes; }
            set { structType.Attributes = value; }
        }

        public override PartialStructNestedClassCollectionWithCodeAnalysis Classes
        {
            get { return partialType.Classes; }
            set { partialType.Classes = value; }
        }

        public override ICollection<PartialStructConstructorWithCodeAnalysis> Constructors
        {
            get { return partialType.Constructors; }
            set { partialType.Constructors = value; }
        }

        public override ICollection<ConversionOperatorWithCodeAnalysis> ConversionOperators
        {
            get { return structType.ConversionOperators; }
            set { structType.ConversionOperators = value; }
        }

        public override ICollection<PartialStructNestedDelegateWithCodeAnalysis> Delegates
        {
            get { return partialType.Delegates; }
            set { partialType.Delegates = value; }
        }
        
        public override ICollection<PartialStructNestedEnumWithCodeAnalysis> Enums
        {
            get { return partialType.Enums; }
            set { partialType.Enums = value; }
        }

        public override PartialStructEventCollectionWithCodeAnalysis Events
        {
            get { return partialType.Events; }
            set { partialType.Events = value; }
        }

        public override PartialStructFieldCollectionWithCodeAnalysis Fields
        {
            get { return partialType.Fields; }
            set { partialType.Fields = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return structType.GenericParameters; }
            set { structType.GenericParameters = value; }
        }

        public override PartialStructIndexerCollectionWithCodeAnalysis Indexers
        {
            get { return partialType.Indexers; }
            set { partialType.Indexers = value; }
        }

        public override ICollection<PartialStructNestedInterfaceWithCodeAnalysis> Interfaces
        {
            get { return partialType.Interfaces; }
            set { partialType.Interfaces = value; }
        }

        public override PartialStructMethodCollectionWithCodeAnalysis Methods
        {
            get { return partialType.Methods; }
            set { partialType.Methods = value; }
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

        public override PartialStructPropertyCollectionWithCodeAnalysis Properties
        {
            get { return partialType.Properties; }
            set { partialType.Properties = value; }
        }

        public override PartialStructNestedStructCollectionWithCodeAnalysis Structs
        {
            get { return partialType.Structs; }
            set { partialType.Structs = value; }
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
            get { return structType.Document; }
            set { structType.Document = value; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return structType.Namespace; }
            set { structType.Namespace = value; }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return structType.Project; }
            set { structType.Project = value; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return structType.Solution; }
            set { structType.Solution = value; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return structType.Visibility; }
            set { structType.Visibility = value; }
        }

        INode<StructDeclarationSyntax> IHasNode<StructDeclarationSyntax>.Node
        {
            get { return structType.Struct.Node; }
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
