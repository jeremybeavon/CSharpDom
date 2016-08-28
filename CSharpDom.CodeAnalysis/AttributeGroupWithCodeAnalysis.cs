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
        private readonly Node<AttributeGroupWithCodeAnalysis, AttributeListSyntax> node;
        private readonly Guid internalId;
        private readonly SeparatedSyntaxListWrapper<
            AttributeGroupWithCodeAnalysis,
            AttributeListSyntax,
            AttributeWithCodeAnalysis,
            AttributeSyntax> attributes;
        
        internal AttributeGroupWithCodeAnalysis(AccessorWithCodeAnalysis parent)
            : this()
        {
            AccessorParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(ConstructorWithCodeAnalysis parent)
            : this()
        {
            ConstructorParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(ConversionOperatorWithCodeAnalysis parent)
            : this()
        {
            ConversionOperatorParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(EventPropertyWithCodeAnalysis parent, EventPropertyAttributeType attributeType)
            : this()
        {
            switch (attributeType)
            {
                case EventPropertyAttributeType.Normal:
                    EventPropertyParent = parent;
                    break;
                case EventPropertyAttributeType.AddAccessor:
                    EventPropertyAddAccessorParent = parent;
                    break;
                case EventPropertyAttributeType.RemoveAccessor:
                    EventPropertyRemoveAccessorParent = parent;
                    break;
            }
        }

        internal AttributeGroupWithCodeAnalysis(GenericParameterDeclarationWithCodeAnalysis parent)
            : this()
        {
            GenericParameterParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(MethodWithCodeAnalysis parent)
            : this()
        {
            MethodParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(OperatorOverloadWithCodeAnalysis parent)
            : this()
        {
            OperatorOverloadParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(ParameterWithCodeAnalysis parent)
            : this()
        {
            ParameterParent = parent;
        }

        internal AttributeGroupWithCodeAnalysis(PropertyWithCodeAnalysis parent)
            : this()
        {
            PropertyParent = parent;
        }

        private AttributeGroupWithCodeAnalysis()
        {
            node = new Node<AttributeGroupWithCodeAnalysis, AttributeListSyntax>(this);
            attributes = new SeparatedSyntaxListWrapper<AttributeGroupWithCodeAnalysis, AttributeListSyntax, AttributeWithCodeAnalysis, AttributeSyntax>(
                node,
                syntax => syntax.Attributes,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributes(childSyntax),
                newParent => new AttributeWithCodeAnalysis(newParent),
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

        internal IChildCollection<AttributeWithCodeAnalysis, AttributeSyntax> AttributeList
        {
             get { return attributes; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal AccessorWithCodeAnalysis AccessorParent
        {
            get { return node.GetParentNode<AccessorWithCodeAnalysis>(); }
            set { node.SetParentNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(value, parent => parent.AttributeList); }
        }

        internal ConstructorWithCodeAnalysis ConstructorParent
        {
            get { return node.GetParentNode<ConstructorWithCodeAnalysis>(); }
            set { node.SetParentNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(value, parent => parent.AttributeList); }
        }

        internal ConversionOperatorWithCodeAnalysis ConversionOperatorParent
        {
            get { return node.GetParentNode<ConversionOperatorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                    value,
                    parent => parent.AttributeList);
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set { node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(value, parent => parent.AttributeList); }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyAddAccessorParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set { node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(value, parent => parent.AddAttributeList); }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyRemoveAccessorParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set { node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(value, parent => parent.RemoveAttributeList); }
        }

        internal GenericParameterDeclarationWithCodeAnalysis GenericParameterParent
        {
            get { return node.GetParentNode<GenericParameterDeclarationWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(
                    value,
                    parent => parent.AttributeList);
            }
        }

        internal MethodWithCodeAnalysis MethodParent
        {
            get { return node.GetParentNode<MethodWithCodeAnalysis>(); }
            set { node.SetParentNode<MethodWithCodeAnalysis, MethodDeclarationSyntax>(value, parent => parent.AttributeList); }
        }

        internal OperatorOverloadWithCodeAnalysis OperatorOverloadParent
        {
            get { return node.GetParentNode<OperatorOverloadWithCodeAnalysis>(); }
            set { node.SetParentNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(value, parent => parent.AttributeList); }
        }

        internal ParameterWithCodeAnalysis ParameterParent
        {
            get { return node.GetParentNode<ParameterWithCodeAnalysis>(); }
            set { node.SetParentNode<ParameterWithCodeAnalysis, ParameterSyntax>(value, parent => parent.AttributeList); }
        }

        internal PropertyWithCodeAnalysis PropertyParent
        {
            get { return node.GetParentNode<PropertyWithCodeAnalysis>(); }
            set { node.SetParentNode<PropertyWithCodeAnalysis, PropertyDeclarationSyntax>(value, parent => parent.AttributeList); }
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
