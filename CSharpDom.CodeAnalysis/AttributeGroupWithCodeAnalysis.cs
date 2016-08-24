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
        IHasId
    {
        private readonly Node<AttributeListSyntax> node;
        private readonly Guid internalId;
        private readonly SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis> attributes;
        
        internal AttributeGroupWithCodeAnalysis(AccessorWithCodeAnalysis parent)
        {
            node = new Node<AttributeListSyntax>();
            attributes = new SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis>(
                () => node.Syntax.Attributes,
                list => node.Syntax = node.Syntax.WithAttributes(list),
                () => new AttributeWithCodeAnalysis(this),
                this,
                (child, newParent) => child.Parent = newParent);
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

        internal SeparatedSyntaxListWrapper<AttributeWithCodeAnalysis, AttributeSyntax, AttributeGroupWithCodeAnalysis> AttributeList
        {
             get { return attributes; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
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
