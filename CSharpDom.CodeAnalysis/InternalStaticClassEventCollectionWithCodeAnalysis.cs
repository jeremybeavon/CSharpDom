using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassEventCollectionWithCodeAnalysis<TStaticClass> :
        StaticClassEventCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> type;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal InternalStaticClassEventCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            events = new StaticTypeMemberListWrapper<TStaticClass, StaticClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassEventWithCodeAnalysis());
            eventProperties = new StaticTypeMemberListWrapper<TStaticClass, StaticClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
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
    }
}
