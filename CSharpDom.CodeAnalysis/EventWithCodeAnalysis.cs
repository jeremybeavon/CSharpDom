using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
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
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasNode<EventFieldDeclarationSyntax>
    {
        private readonly Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            EventWithCodeAnalysis,
            EventFieldDeclarationSyntax,
            DelegateReferenceWithCodeAnalysis,
            NameSyntax> eventType;
        
        internal EventWithCodeAnalysis()
        {
            node = new Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            eventType = new CachedChildNode<EventWithCodeAnalysis, EventFieldDeclarationSyntax, DelegateReferenceWithCodeAnalysis, NameSyntax>(
                node,
                () => new DelegateReferenceWithCodeAnalysis(new UnspecifiedTypeReferenceWithCodeAnalysis()),
                syntax => (NameSyntax)syntax.Declaration.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithDeclaration(parentSyntax.Declaration.WithType(childSyntax)));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParent<IBasicType>(); }
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

        internal Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax> AttributeList
        {
            get { return attributes; }
        }

        INode<EventFieldDeclarationSyntax> IHasNode<EventFieldDeclarationSyntax>.Node => node;
    }
}
