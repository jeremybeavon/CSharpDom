using CSharpDom.Common;
using CSharpDom.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceEventWithCodeAnalysis :
        EditableExplicitInterfaceEvent<
            AttributeGroupWithCodeAnalysis,
            IType,
            InterfaceReferenceWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<EventDeclarationSyntax>
    {
        private readonly EventPropertyWithCodeAnalysis @event;
        private readonly CachedChildNode<
            EventPropertyWithCodeAnalysis,
            EventDeclarationSyntax,
            InterfaceReferenceWithCodeAnalysis> explicitInterface;
        
        private ExplicitInterfaceEventWithCodeAnalysis(EventPropertyWithCodeAnalysis @event, IType declaringType)
        {
            this.@event = @event;
            base.DeclaringType = declaringType;
            explicitInterface = new CachedChildNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax, InterfaceReferenceWithCodeAnalysis>(
                @event.Node,
                null,
                null,
                null);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
            set { @event.AddAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return @event.AddBody; }
            set { @event.AddBody = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
            set { @event.Attributes = value; }
        }

        public override IType DeclaringType
        {
            get { return @event.DeclaringType; }
            set { @event.DeclaringType = value; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
            set { @event.EventType = value; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface.Value; }
        }

        public override string Name
        {
            get { return @event.Name; }
            set { @event.Name = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
            set { @event.RemoveAttributes = value; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
            set { @event.RemoveBody = value; }
        }

        public EventDeclarationSyntax Syntax
        {
            get { return @event.Syntax; }
            set { @event.Syntax = value; }
        }
    }
}
