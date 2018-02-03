using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumWithCodeAnalysis :
        EditableEnum<
            NamespaceWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            SolutionWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            EnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        IHasNode<EnumDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<EnumWithCodeAnalysis, EnumDeclarationSyntax> node;
        private readonly DocumentWithCodeAnalysis document;
        private readonly AttributeListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxNodeList<
            EnumWithCodeAnalysis,
            EnumDeclarationSyntax,
            EnumMemberWithCodeAnalysis,
            EnumMemberDeclarationSyntax> enumMembers;

        internal EnumWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            node = new Node<EnumWithCodeAnalysis, EnumDeclarationSyntax>(this);
            this.document = document;
            attributes = new AttributeListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            enumMembers = new SeparatedSyntaxNodeList<EnumWithCodeAnalysis, EnumDeclarationSyntax, EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(
                node,
                syntax => syntax.Members,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax),
                () => new EnumMemberWithCodeAnalysis());
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IList<EnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return enumMembers; }
            set { enumMembers.ReplaceList(value); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return node.GetParent<NamespaceWithCodeAnalysis>(); }
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
                EnumDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithTypeVisibilityModifier(value));
            }
        }

        public override EnumBaseType BaseType
        {
            get { return Syntax.ToBaseType(); }
            set { Syntax = Syntax.ToBaseType(value); }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }
        
        public EnumDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<EnumDeclarationSyntax> IHasNode<EnumDeclarationSyntax>.Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
