using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public class AttributeGroupWithCodeAnalysis :
        EditableAttributeGroup<AttributeWithCodeAnalysis>,
        IHasSyntax<AttributeListSyntax>,
        IHasNode<AttributeListSyntax>
    {
        private readonly Node<AttributeGroupWithCodeAnalysis, AttributeListSyntax> node;
        private readonly Guid internalId;
        private readonly SeparatedSyntaxListWrapper<
            AttributeGroupWithCodeAnalysis,
            AttributeListSyntax,
            AttributeWithCodeAnalysis,
            AttributeSyntax> attributes;
        
        internal AttributeGroupWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<AttributeGroupWithCodeAnalysis, AttributeListSyntax>(this);
            attributes = new SeparatedSyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AttributeWithCodeAnalysis, AttributeSyntax>(
                node,
                syntax => syntax.Attributes,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributes(childSyntax),
                () => new AttributeWithCodeAnalysis());
        }

        public override ICollection<AttributeWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set
            {
                 node.Syntax = node.Syntax.WithAttributes(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax)));
            }
        }

        public AttributeListSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IChildCollection<AttributeWithCodeAnalysis, AttributeSyntax> AttributeList
        {
             get { return attributes; }
        }
        
        INode<AttributeListSyntax> IHasNode<AttributeListSyntax>.Node
        {
            get { return node; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
