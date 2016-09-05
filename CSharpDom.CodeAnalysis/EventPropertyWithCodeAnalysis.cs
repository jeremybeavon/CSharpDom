using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
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
        IHasSyntax<EventDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object eventProperty;
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

        internal EventPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassEventPropertyWithCodeAnalysis eventProperty)
            : this(eventProperty)
        {
            ClassParent = parent;
        }

        internal EventPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ExplicitInterfaceEventWithCodeAnalysis eventProperty)
            : this(eventProperty)
        {
            ExplicitInterfaceClassParent = parent;
        }

        internal EventPropertyWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassEventPropertyWithCodeAnalysis eventProperty)
            : this(eventProperty)
        {
            SealedClassParent = parent;
        }

        private EventPropertyWithCodeAnalysis(object eventProperty)
        {
            node = new Node<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(this);
            this.eventProperty = eventProperty;
            addAttributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.GetAccessor(SyntaxKind.AddKeyword).AttributeLists,
                (parentSyntax, childSyntax) => CreateAccessorAttributes(parentSyntax, childSyntax, SyntaxKind.AddKeyword),
                parent => new AttributeGroupWithCodeAnalysis(parent, EventPropertyAttributeType.AddAccessor),
                (child, parent) => child.EventPropertyAddAccessorParent = parent);
            addBody = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>(
                node,
                parent => new MethodBodyWithCodeAnalysis(parent, EventPropertyBodyType.AddAccessor),
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.AddKeyword),
                (child, parent) => child.EventPropertyAddAccessorParent = parent);
            attributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent, EventPropertyAttributeType.Normal),
                (child, parent) => child.EventPropertyParent = parent);
            eventType = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, DelegateReferenceWithCodeAnalysis, NameSyntax>(
                node,
                parent => new DelegateReferenceWithCodeAnalysis(parent),
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax),
                (child, parent) => child.TypeReference.EventPropertyParent = parent);
            removeAttributes = new AttributeListWrapper<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                node,
                syntax => syntax.GetAccessor(SyntaxKind.RemoveKeyword).AttributeLists,
                (parentSyntax, childSyntax) => CreateAccessorAttributes(parentSyntax, childSyntax, SyntaxKind.RemoveKeyword),
                parent => new AttributeGroupWithCodeAnalysis(parent, EventPropertyAttributeType.RemoveAccessor),
                (child, parent) => child.EventPropertyRemoveAccessorParent = parent);
            removeBody = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>(
                node,
                parent => new MethodBodyWithCodeAnalysis(parent, EventPropertyBodyType.RemoveAccessor),
                (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.RemoveKeyword),
                (child, parent) => child.EventPropertyRemoveAccessorParent = parent);
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
            get { return base.DeclaringType; }
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

        internal IAttributeCollection AddAttributeList
        {
            get { return addAttributes; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IAttributeCollection RemoveAttributeList
        {
            get { return removeAttributes; }
        }

        internal Node<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal ClassTypeWithCodeAnalysis ClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Events.EventPropertyList);
            }
        }

        internal ClassTypeWithCodeAnalysis ExplicitInterfaceClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Events.ExplicitInterfaceEventList);
            }
        }

        internal ClassTypeWithCodeAnalysis SealedClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.SealedType.Events.EventPropertyList);
            }
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

        T ISimpleMember.Member<T>()
        {
            return (T)eventProperty;
        }
    }
}
