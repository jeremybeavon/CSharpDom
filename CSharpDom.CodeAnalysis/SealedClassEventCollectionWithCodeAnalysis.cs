using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassEventCollectionWithCodeAnalysis :
        EditableSealedClassEventCollection<
            SealedClassEventWithCodeAnalysis,
            SealedClassEventPropertyWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassEventListWrapper<SealedClassEventWithCodeAnalysis> events;
        private readonly ClassEventPropertyListWrapper<SealedClassEventPropertyWithCodeAnalysis> eventProperties;

        internal SealedClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<SealedClassEventWithCodeAnalysis>(
                classType.Node,
                parent => new SealedClassEventWithCodeAnalysis(parent),
                (child, parent) => child.Event.SealedClassParent = parent);
            eventProperties = new ClassEventPropertyListWrapper<SealedClassEventPropertyWithCodeAnalysis>(
                classType.Node,
                parent => new SealedClassEventPropertyWithCodeAnalysis(parent),
                (child, parent) => child.EventProperty.SealedClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }
        
        public override ICollection<SealedClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { classType.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return classType.Events.ExplicitInterfaceEvents; }
            set { classType.Events.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<SealedClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { classType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
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
