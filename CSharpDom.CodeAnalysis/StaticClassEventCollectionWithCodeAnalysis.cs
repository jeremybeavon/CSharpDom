using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticClassEventWithCodeAnalysis,
            StaticClassEventPropertyWithCodeAnalysis>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticClassMemberListWrapper<
            StaticClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly StaticClassMemberListWrapper<
            StaticClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal StaticClassEventCollectionWithCodeAnalysis(StaticClassWithCodeAnalysis type)
        {
            this.type = type;
            events = new StaticClassMemberListWrapper<StaticClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassEventWithCodeAnalysis());
            eventProperties = new StaticClassMemberListWrapper<StaticClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
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
