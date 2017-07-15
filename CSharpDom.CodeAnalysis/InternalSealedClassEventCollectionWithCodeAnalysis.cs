using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalSealedClassEventCollectionWithCodeAnalysis<TClass> :
        SealedClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassEventListWrapper<TClass, SealedClassEventWithCodeAnalysis> events;
        private readonly ClassEventPropertyListWrapper<TClass, SealedClassEventPropertyWithCodeAnalysis> eventProperties;

        internal InternalSealedClassEventCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            events = new ClassEventListWrapper<TClass, SealedClassEventWithCodeAnalysis>(
                classType.Node,
                () => new SealedClassEventWithCodeAnalysis());
            eventProperties = new ClassEventPropertyListWrapper<TClass, SealedClassEventPropertyWithCodeAnalysis>(
                classType.Node,
                () => new SealedClassEventPropertyWithCodeAnalysis(),
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
    }
}
