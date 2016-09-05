using System;
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
        IHasSyntax<EventFieldDeclarationSyntax>,
        IHasId,
        ISimpleMember
    {
        private readonly Guid internalId;
        private readonly object @event;
        private readonly Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax> node;
        private readonly AttributeListWrapper<EventWithCodeAnalysis, EventFieldDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            EventWithCodeAnalysis,
            EventFieldDeclarationSyntax,
            DelegateReferenceWithCodeAnalysis,
            NameSyntax> eventType;

        internal EventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, AbstractEventWithCodeAnalysis @event)
            : this(@event)
        {
            AbstractClassParent = parent;
        }

        internal EventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassEventWithCodeAnalysis @event, ClassType classType)
            : this(@event)
        {
            SetClassParent(parent, classType);
        }

        internal EventWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassEventWithCodeAnalysis @event)
            : this(@event)
        {

        }

        internal EventWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent, InterfaceEventWithCodeAnalysis @event)
            : this(@event)
        {
            InterfaceParent = parent;
        }

        private EventWithCodeAnalysis(object @event)
        {
            this.@event = @event;
            internalId = Guid.NewGuid();
            node = new Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax>(this);
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
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
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

        internal ClassTypeWithCodeAnalysis AbstractClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.AbstractType.Events.AbstractEventList);
            }
        }

        internal InterfaceTypeWithCodeAnalysis InterfaceParent
        {
            get { return node.GetParentNode<InterfaceTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(
                    value,
                    parent => parent.EventList);
            }
        }

        internal ClassTypeWithCodeAnalysis SealedClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.SealedType.Events.EventList);
            }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
        
        internal void SetClassParent(ClassTypeWithCodeAnalysis value, ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Normal:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Events.EventList);
                    break;
                case ClassType.Abstract:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.AbstractType.Events.EventList);
                    break;
            }
        }

        T ISimpleMember.Member<T>()
        {
            return (T)@event;
        }
    }
}
