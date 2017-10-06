using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EventPropertyWithCodeAnalysis :
        EditableEventProperty<
            AttributeGroupWithCodeAnalysis,
            IType,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>
    {
        private readonly Node<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> node;
        private readonly AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> addAttributes;
        private readonly CachedChildNode<
            EventPropertyWithCodeAnalysis,
            EventDeclarationSyntax,
            MethodBodyWithCodeAnalysis,
            BlockSyntax> addBody;
        private readonly AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            EventPropertyWithCodeAnalysis,
            EventDeclarationSyntax,
            DelegateReferenceWithCodeAnalysis,
            NameSyntax> eventType;
        private readonly AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> removeAttributes;
        private readonly CachedChildNode<
            EventPropertyWithCodeAnalysis,
            EventDeclarationSyntax,
            MethodBodyWithCodeAnalysis,
            BlockSyntax> removeBody;

        internal EventPropertyWithCodeAnalysis()
        {
            node = new Node<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(this);
            addAttributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.GetAccessor(SyntaxKind.AddKeyword).AttributeLists,
                (parentSyntax, childSyntax) => CreateAccessorAttributes(parentSyntax, childSyntax, SyntaxKind.AddKeyword));
            addBody = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>(
                node,
                () => new MethodBodyWithCodeAnalysis(),
                syntax => syntax.GetAccessor(SyntaxKind.AddKeyword).Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.AddKeyword));
            attributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            eventType = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, DelegateReferenceWithCodeAnalysis, NameSyntax>(
                node,
                () => new DelegateReferenceWithCodeAnalysis(new UnspecifiedTypeReferenceWithCodeAnalysis()),
                syntax => (NameSyntax)syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
            removeAttributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.GetAccessor(SyntaxKind.RemoveKeyword).AttributeLists,
                (parentSyntax, childSyntax) => CreateAccessorAttributes(parentSyntax, childSyntax, SyntaxKind.RemoveKeyword));
            removeBody = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>(
                node,
                () => new MethodBodyWithCodeAnalysis(),
                syntax => syntax.GetAccessor(SyntaxKind.RemoveKeyword).Body,
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.RemoveKeyword));
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return addAttributes; }
            set { Syntax = CreateAccessorAttributes(Syntax, value, SyntaxKind.AddKeyword); }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return addBody.Value; }
            set { addBody.Value = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IType DeclaringType
        {
            get { return node.GetParentNode<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return eventType.Value; }
            set { }
        }

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return removeAttributes; }
            set { Syntax = CreateAccessorAttributes(Syntax, value, SyntaxKind.RemoveKeyword); }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return removeBody.Value; }
            set { removeBody.Value = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        internal Node<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> Node
        {
            get { return node; }
        }
        
        private static EventDeclarationSyntax CreateAccessorAttributes(
            EventDeclarationSyntax parentSyntax,
            IEnumerable<AttributeGroupWithCodeAnalysis> attributes,
            SyntaxKind kind)
        {
            return CreateAccessorAttributes(parentSyntax, SyntaxFactory.List(attributes.Select(item => item.Syntax)), kind);
        }

        private static EventDeclarationSyntax CreateAccessorAttributes(
            EventDeclarationSyntax parentSyntax,
            SyntaxList<AttributeListSyntax> childSyntax,
            SyntaxKind kind)
        {
            AccessorDeclarationSyntax accessor = parentSyntax.GetAccessor(kind);
            return parentSyntax.WithAccessor(kind, accessor.WithAttributeLists(childSyntax));
        }
    }
}
