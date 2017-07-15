using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassEventCollectionWithCodeAnalysis<TClass> :
        AbstractClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassEventListWrapper<TClass, ClassEventWithCodeAnalysis> events;
        private readonly ClassEventListWrapper<TClass, AbstractEventWithCodeAnalysis> abstractEvents;

        internal InternalAbstractClassEventCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<TClass, ClassEventWithCodeAnalysis>(
                classType.Node,
                () => new ClassEventWithCodeAnalysis(),
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
    }
}
