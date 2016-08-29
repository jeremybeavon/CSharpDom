using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class UnspecifiedTypeReferenceWithCodeAnalysis :
        EditableUnspecifiedTypeReference<GenericParameterWithCodeAnalysis>,
        IHasSyntax<NameSyntax>,
        ITypeReferenceWithCodeAnalysis,
        IHasId//,
                                      //IVisitable<IReflectionVisitor>
    {
        private readonly Guid internalId;
        private readonly Node<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax> node;
        private readonly GenericParameterListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis> genericParameters;

        internal UnspecifiedTypeReferenceWithCodeAnalysis(AttributeWithCodeAnalysis parent)
            : this()
        {
            AttributeParent = parent;
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis(EventPropertyWithCodeAnalysis parent)
            : this()
        {
            EventPropertyParent = parent;
        }

        internal UnspecifiedTypeReferenceWithCodeAnalysis(EventWithCodeAnalysis parent)
            : this()
        {
            EventParent = parent;
        }

        private UnspecifiedTypeReferenceWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
            node = new Node<UnspecifiedTypeReferenceWithCodeAnalysis, NameSyntax>(this);
            genericParameters = new GenericParameterListWrapper<UnspecifiedTypeReferenceWithCodeAnalysis>(
                node,
                syntax => syntax.ToGenericParameters(),
                (parentSyntax, childSyntax) => parentSyntax.WithGenericParameters(childSyntax),
                parent => new GenericParameterWithCodeAnalysis(parent),
                (child, parent) => child.UnspecifiedTypeReferenceParent = parent);
        }

        public override IList<GenericParameterWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters; }
            set { Syntax = Syntax.WithGenericParameters(value); }
        }

        public override string Name
        {
            get { return Syntax.ToName(); }
            set { Syntax = Syntax.WithName(value); }
        }

        public NameSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (NameSyntax)value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        internal IChildCollection<GenericParameterWithCodeAnalysis, TypeSyntax> GenericParameterList
        {
            get { return genericParameters; }
        }

        internal AttributeWithCodeAnalysis AttributeParent
        {
            get { return node.GetParentNode<AttributeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<AttributeWithCodeAnalysis, AttributeSyntax>(
                    value,
                    syntax => syntax.Name,
                    (parentSyntax, childSyntax) => parentSyntax.WithName(childSyntax));
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                    value,
                    syntax => (NameSyntax)syntax.Type,
                    (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
            }
        }

        internal EventWithCodeAnalysis EventParent
        {
            get { return node.GetParentNode<EventWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                    value,
                    syntax => (NameSyntax)syntax.Declaration.Type,
                    (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)));
            }
        }

        internal GenericParameterDeclarationWithCodeAnalysis GenericParameterDeclarationParent
        {
            get { return node.GetParentNode<GenericParameterDeclarationWithCodeAnalysis>(); }
            set
            {
                //node.SetParentNode<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax>(
                //    value,
                //    syntax => syntax.Constraints.,
                //    (parentSyntax, childSyntax) => parentSyntax.)
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitUnspecifiedTypeReferenceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
