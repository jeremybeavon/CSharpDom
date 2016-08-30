﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EventWithCodeAnalysis :
        EditableEvent<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            DelegateReferenceWithCodeAnalysis>,
        IHasSyntax<EventFieldDeclarationSyntax>
    {
        private readonly Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            EventWithCodeAnalysis,
            EventFieldDeclarationSyntax,
            DelegateReferenceWithCodeAnalysis,
            NameSyntax> eventType;

        private EventWithCodeAnalysis(IBasicType declaringType)
        {
            node = new Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(this);
            base.DeclaringType = declaringType;
            attributes = new AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.EventParent = parent);
            eventType = new CachedChildNode<EventWithCodeAnalysis, EventFieldDeclarationSyntax, DelegateReferenceWithCodeAnalysis, NameSyntax>(
                node,
                parent => new DelegateReferenceWithCodeAnalysis(parent),
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)),
                (child, parent) => child.TypeReference.EventParent = parent);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override IBasicType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return eventType.Value; }
            set { eventType.Value = value; }
        }

        public override string Name
        {
            get { return Syntax.Declaration.Variables[0].Identifier.Text; }
            set
            {
                EventFieldDeclarationSyntax syntax = Syntax;
                SeparatedSyntaxList<VariableDeclaratorSyntax> variables = syntax.Declaration.Variables;
                VariableDeclaratorSyntax newVariable = variables[0].WithIdentifier(SyntaxFactory.Identifier(value));
                Syntax = syntax.WithDeclaration(syntax.Declaration.WithVariables(variables.Replace(variables[0], newVariable)));
            }
        }

        public EventFieldDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax> AttributeList
        {
            get { return attributes; }
        }
    }
}
