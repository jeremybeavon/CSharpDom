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
        private readonly ClassEventPropertyListWrapper<ClassEventPropertyWithCodeAnalysis> eventProperties;
        private readonly ClassEventPropertyListWrapper<ExplicitInterfaceEventWithCodeAnalysis> explicitInterfaceEvents;
        private readonly ClassEventListWrapper<ClassEventWithCodeAnalysis> events;

        internal ClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            eventProperties = new ClassEventPropertyListWrapper<ClassEventPropertyWithCodeAnalysis>(
                classType.Node,
                parent => new ClassEventPropertyWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.ClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
            explicitInterfaceEvents = new ClassEventPropertyListWrapper<ExplicitInterfaceEventWithCodeAnalysis>(
                classType.Node,
                parent => new ExplicitInterfaceEventWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.ExplicitInterfaceClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            events = new ClassEventListWrapper<ClassEventWithCodeAnalysis>(
                classType.Node,
                parent => new ClassEventWithCodeAnalysis(parent, ClassType.Normal),
                (child, parent) => child.Event.SetClassParent(parent, ClassType.Normal));
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
