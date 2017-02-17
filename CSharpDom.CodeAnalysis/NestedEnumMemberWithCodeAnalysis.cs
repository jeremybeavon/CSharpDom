using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedEnumMemberWithCodeAnalysis :
        EditableNestedEnumMember<AttributeGroupWithCodeAnalysis, INestedEnum>,
        IHasSyntax<EnumMemberDeclarationSyntax>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Node<NestedEnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax> node;
        private readonly AttributeListWrapper<NestedEnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax> attributes;
        
        private NestedEnumMemberWithCodeAnalysis()
        {
            node = new Node<NestedEnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<NestedEnumMemberWithCodeAnalysis, EnumMemberDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override INestedEnum DeclaringType
        {
            get { return node.GetParentNode<INestedEnum>(); }
            set { throw new NotSupportedException(); }
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
        
        /*
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumMemberWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
