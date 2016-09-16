using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
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
        private readonly AttributeListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxListWrapper<
            EnumWithCodeAnalysis,
            EnumDeclarationSyntax,
            EnumMemberWithCodeAnalysis,
            EnumMemberDeclarationSyntax> enumMembers;

        internal EnumWithCodeAnalysis()
        {
            node = new Node<EnumWithCodeAnalysis, EnumDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            enumMembers = new SeparatedSyntaxListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax, EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(
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
            get { throw new NotImplementedException(); }
            set { }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { throw new NotImplementedException(); }
            set { }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { throw new NotImplementedException(); }
            set { }
        }
        
        public override TypeVisibilityModifier Visibility
        {
            get { throw new NotImplementedException(); }
            set { }
        }

        public override EnumBaseType BaseType
        {
            get { throw new NotImplementedException(); }
            set { }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { throw new NotImplementedException(); }
            set { }
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
