using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly StaticTypeMemberListWrapper<
            EventWithCodeAnalysis,
            StaticClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly StaticTypeMemberListWrapper<
            EventPropertyWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal StaticClassEventCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            events = new StaticTypeMemberListWrapper<EventWithCodeAnalysis, StaticClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassEventWithCodeAnalysis());
            eventProperties = new StaticTypeMemberListWrapper<EventPropertyWithCodeAnalysis, StaticClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                type.Node,
                () => new StaticClassEventPropertyWithCodeAnalysis());
        }
        
        public override ICollection<StaticClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { type.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }
        
        public override ICollection<StaticClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { type.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> EventList
        {
            get { return events; }
        }

        internal IChildCollection<EventPropertyWithCodeAnalysis, EventDeclarationSyntax> EventPropertyList
        {
            get { return eventProperties; }
        }
    }
}
