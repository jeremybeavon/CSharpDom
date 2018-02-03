using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassEventCollectionWithCodeAnalysis<TClass> :
        AbstractClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassEventListWrapper<TClass, AbstractClassEventWithCodeAnalysis> events;
        private readonly WrappedCollection<
            ClassEventPropertyWithCodeAnalysis,
            AbstractClassEventPropertyWithCodeAnalysis> eventProperties;
        private readonly ClassEventListWrapper<TClass, AbstractEventWithCodeAnalysis> abstractEvents;

        internal InternalAbstractClassEventCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<TClass, AbstractClassEventWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassEventWithCodeAnalysis(),
                syntax => !syntax.Modifiers.IsAbstract());
            eventProperties = new WrappedCollection<ClassEventPropertyWithCodeAnalysis, AbstractClassEventPropertyWithCodeAnalysis>(
                classType.Events.EventProperties,
                parent => new AbstractClassEventPropertyWithCodeAnalysis(parent),
                child => child.EventProperty,
                value => classType.Events.EventProperties = value);
            abstractEvents = new ClassEventListWrapper<TClass, AbstractEventWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractEventWithCodeAnalysis(),
                syntax => syntax.Modifiers.IsAbstract());
        }

        public override ICollection<AbstractEventWithCodeAnalysis> AbstractEvents
        {
            get { return abstractEvents; }
            set { classType.Members.CombineList(nameof(AbstractEvents), value.Select(item => item.Syntax)); }
        }

        public override ICollection<AbstractClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { eventProperties.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return classType.Events.ExplicitInterfaceEvents; }
            set { classType.Events.ExplicitInterfaceEvents = value; }
        }

        public override ICollection<AbstractClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { classType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }
    }
}
