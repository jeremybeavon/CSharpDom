using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceEventWithCodeAnalysis :
        AbstractExplicitInterfaceEvent<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            DelegateReferenceWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasEventDefinition
    {
        private readonly EventPropertyWithCodeAnalysis @event;
        private readonly string name;
        private readonly InterfaceReferenceWithCodeAnalysis explicitInterface;

        internal ExplicitInterfaceEventWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, EventDefinition @event)
        {
            this.@event = new EventPropertyWithCodeAnalysis(declaringType, @event);
            name = @event.Name.Split('.').Last();
            TypeReference interfaceType = @event.AddMethod.FindExplicitInterface();
            explicitInterface = new InterfaceReferenceWithCodeAnalysis(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> AddAttributes
        {
            get { return @event.AddAttributes; }
        }

        public override MethodBodyWithCodeAnalysis AddBody
        {
            get { return @event.AddBody; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return @event.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return @event.DeclaringType; }
        }

        public EventDefinition EventDefinition
        {
            get { return @event.EventDefinition; }
        }

        public override DelegateReferenceWithCodeAnalysis EventType
        {
            get { return @event.EventType; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> RemoveAttributes
        {
            get { return @event.RemoveAttributes; }
        }

        public override MethodBodyWithCodeAnalysis RemoveBody
        {
            get { return @event.RemoveBody; }
        }
    }
}
