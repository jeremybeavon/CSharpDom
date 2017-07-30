using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassEventCollectionWithCodeAnalysis<TClass> :
        StaticClassEventCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> type;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal InternalStaticClassEventCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TClass> type)
        {
            this.type = type;
            events = new ClassMemberListWrapper<TClass, StaticClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassEventWithCodeAnalysis());
            eventProperties = new ClassMemberListWrapper<TClass, StaticClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                type.InternalNode,
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
    }
}
