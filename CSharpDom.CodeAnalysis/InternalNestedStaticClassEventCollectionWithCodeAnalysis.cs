using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassEventCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticClassEventCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal InternalNestedStaticClassEventCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            events = new ClassMemberListWrapper<TStaticClass, NestedStaticClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.InternalNode,
                () => new NestedStaticClassEventWithCodeAnalysis());
            eventProperties = new ClassMemberListWrapper<TStaticClass, NestedStaticClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                type.InternalNode,
                () => new NestedStaticClassEventPropertyWithCodeAnalysis());
        }
        
        public override ICollection<NestedStaticClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { type.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }
        
        public override ICollection<NestedStaticClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { type.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }
    }
}
