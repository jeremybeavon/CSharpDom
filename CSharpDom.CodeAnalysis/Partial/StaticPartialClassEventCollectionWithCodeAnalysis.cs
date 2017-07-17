using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassEventCollectionWithCodeAnalysis :
        EditableStaticClassEventCollection<
            StaticPartialClassEventWithCodeAnalysis,
            StaticPartialClassEventPropertyWithCodeAnalysis>
    {
        private readonly StaticPartialClassWithCodeAnalysis type;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;

        internal StaticPartialClassEventCollectionWithCodeAnalysis(StaticPartialClassWithCodeAnalysis type)
        {
            this.type = type;
            events = new StaticPartialClassMemberListWrapper<StaticPartialClassEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassEventWithCodeAnalysis());
            eventProperties = new StaticPartialClassMemberListWrapper<StaticPartialClassEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassEventPropertyWithCodeAnalysis());
        }

        public override ICollection<StaticPartialClassEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { type.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { type.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }
    }
}
