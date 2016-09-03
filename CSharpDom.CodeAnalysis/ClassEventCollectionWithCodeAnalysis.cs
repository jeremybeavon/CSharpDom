using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassEventCollectionWithCodeAnalysis :
        EditableClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<
            EventPropertyWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;
        private readonly ClassMemberListWrapper<
            EventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis,
            EventDeclarationSyntax> explicitInterfaceEvents;
        private readonly ClassMemberListWrapper<
            EventWithCodeAnalysis,
            ClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;

        internal ClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            eventProperties = new ClassMemberListWrapper<EventPropertyWithCodeAnalysis, ClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                classType.Node,
                parent => new ClassEventPropertyWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.ClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
            explicitInterfaceEvents = new ClassMemberListWrapper<EventPropertyWithCodeAnalysis, ExplicitInterfaceEventWithCodeAnalysis, EventDeclarationSyntax>(
                classType.Node,
                parent => new ExplicitInterfaceEventWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.ExplicitInterfaceClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            events = new ClassMemberListWrapper<EventWithCodeAnalysis, ClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                classType.Node,
                parent => new ClassEventWithCodeAnalysis(parent),
                (child, parent) => child.Event.ClassParent = parent);
        }

        public override ICollection<ClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { classType.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceEvents), value.Select(item => item.Syntax)); }
        }
        
        public override ICollection<ClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { classType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
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
