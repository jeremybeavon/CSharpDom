using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassEventCollectionWithCodeAnalysis<TClass> :
        AbstractClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalAbstractTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassEventListWrapper<TClass, AbstractClassEventWithCodeAnalysis> events;
        private readonly ClassEventListWrapper<TClass, AbstractEventWithCodeAnalysis> abstractEvents;

        internal InternalAbstractClassEventCollectionWithCodeAnalysis(InternalAbstractTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<TClass, AbstractClassEventWithCodeAnalysis>(
                classType.Node,
                () => new AbstractClassEventWithCodeAnalysis(),
                syntax => !syntax.Modifiers.IsAbstract());
            abstractEvents = new ClassEventListWrapper<TClass, AbstractEventWithCodeAnalysis>(
                classType.Node,
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
            get { return classType.Events.EventProperties; }
            set { classType.Events.EventProperties = value; }
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
