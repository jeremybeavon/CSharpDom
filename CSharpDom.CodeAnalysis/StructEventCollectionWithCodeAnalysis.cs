using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructEventCollectionWithCodeAnalysis :
        EditableStructEventCollection<
            StructEventWithCodeAnalysis,
            StructEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<
            EventPropertyWithCodeAnalysis,
            StructEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;
        private readonly StructTypeMemberListWrapper<
            EventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis,
            EventDeclarationSyntax> explicitInterfaceEvents;
        private readonly StructTypeMemberListWrapper<
            EventWithCodeAnalysis,
            StructEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;

        internal StructEventCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            eventProperties = new StructTypeMemberListWrapper<EventPropertyWithCodeAnalysis, StructEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                structType.Node,
                parent => new StructEventPropertyWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.StructParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
            explicitInterfaceEvents = new StructTypeMemberListWrapper<EventPropertyWithCodeAnalysis, ExplicitInterfaceEventWithCodeAnalysis, EventDeclarationSyntax>(
                structType.Node,
                parent => new ExplicitInterfaceEventWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.ExplicitInterfaceStructParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            events = new StructTypeMemberListWrapper<EventWithCodeAnalysis, StructEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                structType.Node,
                parent => new StructEventWithCodeAnalysis(parent),
                (child, parent) => child.Event.StructParent = parent);
        }

        public override ICollection<StructEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { structType.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceEvents), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { structType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> EventPropertyList
        {
            get { return eventProperties; }
        }

        internal IChildCollection<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> ExplicitInterfaceEventList
        {
            get { return explicitInterfaceEvents; }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> EventList
        {
            get { return events; }
        }
    }
}
