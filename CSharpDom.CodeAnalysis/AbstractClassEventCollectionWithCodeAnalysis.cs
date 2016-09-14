using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassEventCollectionWithCodeAnalysis :
        EditableAbstractClassEventCollection<
            ClassEventWithCodeAnalysis,
            ClassEventPropertyWithCodeAnalysis,
            AbstractEventWithCodeAnalysis,
            ExplicitInterfaceEventWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassEventListWrapper<ClassEventWithCodeAnalysis> events;
        private readonly ClassEventListWrapper<AbstractEventWithCodeAnalysis> abstractEvents;

        internal AbstractClassEventCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<ClassEventWithCodeAnalysis>(
                classType.Node,
                () => new ClassEventWithCodeAnalysis(),
                syntax => !syntax.Modifiers.IsAbstract());
            abstractEvents = new ClassEventListWrapper<AbstractEventWithCodeAnalysis>(
                classType.Node,
                () => new AbstractEventWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());
        }

        public override ICollection<AbstractEventWithCodeAnalysis> AbstractEvents
        {
            get { return abstractEvents; }
            set { classType.Members.CombineList(nameof(AbstractEvents), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return classType.Events.EventProperties; }
            set { classType.Events.EventProperties = value; }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return classType.Events.ExplicitInterfaceEvents; }
            set { classType.Events.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<ClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { classType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> AbstractEventList
        {
            get { return abstractEvents; }
        }

        internal IChildCollection<EventWithCodeAnalysis, EventFieldDeclarationSyntax> EventList
        {
            get { return events; }
        }
    }
}
