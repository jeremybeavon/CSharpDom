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
            SealedClassParent = parent;
        }

        internal EventWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent, InterfaceEventWithCodeAnalysis @event)
            : this(@event)
        {
            InterfaceParent = parent;
        }

        internal EventWithCodeAnalysis(StaticTypeWithCodeAnalysis parent, StaticClassEventWithCodeAnalysis @event)
            : this(@event)
        {
            StaticClassParent = parent;
        }

        internal EventWithCodeAnalysis(StructTypeWithCodeAnalysis parent, StructEventWithCodeAnalysis @event)
            : this(@event)
        {
            StructParent = parent;
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

        internal Node<EventWithCodeAnalysis, EventFieldDeclarationSyntax> Node
        {
            get { return node; }
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

        internal StaticTypeWithCodeAnalysis StaticClassParent
        {
            get { return node.GetParentNode<StaticTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Events.EventList);
            }
        }

        internal StructTypeWithCodeAnalysis StructParent
        {
            get { return node.GetParentNode<StructTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StructTypeWithCodeAnalysis, StructDeclarationSyntax>(
                    value,
                    parent => parent.Events.EventList);
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
