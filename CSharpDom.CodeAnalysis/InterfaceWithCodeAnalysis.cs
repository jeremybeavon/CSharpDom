using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceWithCodeAnalysis :
        EditableInterface<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IInterfaceTypeWithCodeAnalysis,
        IHasSyntax<InterfaceDeclarationSyntax>,
        IHasNode<InterfaceDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly InterfaceTypeWithCodeAnalysis type;
        private readonly DocumentWithCodeAnalysis document;

        internal InterfaceWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            type = new InterfaceTypeWithCodeAnalysis();
            this.document = document;
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return type.Events; }
            set { type.Events = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }

        public override ICollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return type.Indexers; }
            set { type.Indexers = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return type.Interfaces; }
            set { type.Interfaces = value; }
        }
        
        public override ICollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return type.Methods; }
            set { type.Methods = value; }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return type.Node.GetParentNode<NamespaceWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return document.Project; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return type.Properties; }
            set { type.Properties = value; }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return document.Solution; }
            set { throw new NotSupportedException(); }
        }

        public InterfaceDeclarationSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToTypeVisibilityModifier(); }
            set
            {
                InterfaceDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        public override bool IsPartial { get => type.IsPartial; set => type.IsPartial = value; }

        INode<InterfaceDeclarationSyntax> IHasNode<InterfaceDeclarationSyntax>.Node
        {
            get { return type.Node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitInterfaceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
