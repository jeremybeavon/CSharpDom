using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumMemberWithCodeAnalysis :
        EditableEnumMember<AttributeGroupWithCodeAnalysis, IEnum>,
        IHasSyntax<EnumMemberDeclarationSyntax>,
        IHasNode<EnumMemberDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax> node;
        private readonly AttributeListWrapper<EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax> attributes;

        internal EnumMemberWithCodeAnalysis()
        {
            node = new Node<EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<EnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IEnum DeclaringType
        {
            get; set;
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public EnumMemberDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<EnumMemberDeclarationSyntax> IHasNode<EnumMemberDeclarationSyntax>.Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumMemberWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
