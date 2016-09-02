using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedInterfaceWithCodeAnalysis :
        EditableNestedInterface<
            AttributeGroupWithCodeAnalysis,
            IType,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IHasSyntax<InterfaceDeclarationSyntax>
    {
        private readonly Node<NestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> node;
        private readonly AttributeListWrapper<NestedInterfaceWithCodeAnalysis, TypeDeclarationSyntax> attributes;
        private readonly MemberListWrapper<
            NestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax,
            EventWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly MemberListWrapper<
            NestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax,
            PropertyWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            PropertyDeclarationSyntax> properties;
        private readonly MemberListWrapper<
            NestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax,
            IndexerWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> indexers;
        private readonly MemberListWrapper<
            NestedInterfaceWithCodeAnalysis,
            InterfaceDeclarationSyntax,
            MethodWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly CombinedMemberList combinedList;

        internal NestedInterfaceWithCodeAnalysis(IType declaringType)
        {
            node = new Node<NestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(this);
            base.DeclaringType = declaringType;
            events = new MemberListWrapper<NestedInterfaceWithCodeAnalysis, InterfaceDeclarationSyntax, EventWithCodeAnalysis, InterfaceEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax),
                parent => new InterfaceEventWithCodeAnalysis(parent),
                (child, parent) => child.Event.NestedInterfaceParent = parent);

            combinedList = new CombinedMemberList(members => Syntax = Syntax.WithMembers(members))
            {
                { nameof(events), () => events.Select(@event => @event.Syntax) },
                { nameof(properties), () => properties.Select(property => property.Syntax) },
                { nameof(indexers), () => indexers.Select(indexer => indexer.Syntax) },
                { nameof(methods), () => methods.Select(method => method.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override IType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { combinedList.CombineList(nameof(events), value.Select(item => item.Syntax)); }
        }

        public InterfaceDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> EventList
        {
            get { return events; }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }

        internal IChildCollection<PropertyWithCodeAnalysis, PropertyDeclarationSyntax> PropertyList
        {
            get { return properties; }
        }
    }
}
