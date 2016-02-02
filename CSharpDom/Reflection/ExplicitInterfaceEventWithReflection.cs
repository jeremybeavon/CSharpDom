using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfaceEventWithReflection :
        AbstractExplicitInterfaceEvent<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            DelegateReferenceWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasEventInfo
    {
        private readonly Lazy<ILMethodBodyWithReflectionEmit> addBody;

        internal ExplicitInterfaceEventWithReflection(EventInfo @event)
        {
            EventInfo = @event;
            addBody = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(@event.AddMethod));
        }

        public override ILMethodBodyWithReflectionEmit AddBody
        {
            get { return addBody.Value; }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public EventInfo EventInfo { get; set; }

        public override DelegateReferenceWithReflection EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ILMethodBodyWithReflectionEmit RemoveBody
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
