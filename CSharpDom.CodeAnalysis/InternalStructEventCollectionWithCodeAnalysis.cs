using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructEventCollectionWithCodeAnalysis<TStruct> :
        StructEventCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructEventPropertyWithCodeAnalysis,
            EventDeclarationSyntax> eventProperties;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            ExplicitInterfaceEventWithCodeAnalysis,
            EventDeclarationSyntax> explicitInterfaceEvents;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructEventWithCodeAnalysis,
            EventFieldDeclarationSyntax> events;

        internal InternalStructEventCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            eventProperties = new StructTypeMemberListWrapper<TStruct, StructEventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                structType.Node,
                () => new StructEventPropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
            explicitInterfaceEvents = new StructTypeMemberListWrapper<TStruct, ExplicitInterfaceEventWithCodeAnalysis, EventDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfaceEventWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            events = new StructTypeMemberListWrapper<TStruct, StructEventWithCodeAnalysis, EventFieldDeclarationSyntax>(
                structType.Node,
                () => new StructEventWithCodeAnalysis());
        }

        public override ICollection<StructEventPropertyWithCodeAnalysis> EventProperties
        {
            get { return eventProperties; }
            set { structType.Members.CombineList(nameof(EventProperties), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceEventWithCodeAnalysis> ExplicitInterfaceEvents
        {
            get { return explicitInterfaceEvents; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceEvents), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructEventWithCodeAnalysis> Events
        {
            get { return events; }
            set { structType.Members.CombineList(nameof(Events), value.Select(item => item.Syntax)); }
        }
    }
}
