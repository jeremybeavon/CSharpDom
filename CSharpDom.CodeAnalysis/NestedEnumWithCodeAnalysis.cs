using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedEnumWithCodeAnalysis :
        EditableNestedEnum<AttributeGroupWithCodeAnalysis, IType, NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        IHasNode<EnumDeclarationSyntax>
    {
        private readonly Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> node;
        private readonly AttributeListWrapper<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> attributes;
        private readonly SeparatedSyntaxNodeList<
            NestedEnumWithCodeAnalysis,
            EnumDeclarationSyntax,
            NestedEnumMemberWithCodeAnalysis,
            EnumMemberDeclarationSyntax> enumMembers;

        internal NestedEnumWithCodeAnalysis()
        {
            node = new Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            enumMembers = new SeparatedSyntaxNodeList<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax, NestedEnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(
                node,
                syntax => syntax.Members,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax),
                () => new NestedEnumMemberWithCodeAnalysis());
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override EnumBaseType BaseType
        {
            get { return Syntax.ToBaseType(); }
            set { Syntax = Syntax.ToBaseType(value); }
        }

        public override IType DeclaringType
        {
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<NestedEnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return enumMembers; }
            set { enumMembers.ReplaceList(value); }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public EnumDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal Node<NestedEnumWithCodeAnalysis, EnumDeclarationSyntax> Node
        {
            get { return node; }
        }

        INode<EnumDeclarationSyntax> IHasNode<EnumDeclarationSyntax>.Node => node;
    }
}
