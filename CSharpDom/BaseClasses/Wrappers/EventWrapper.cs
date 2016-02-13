using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class EventWrapper<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IWrapper<IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TDelegateReference : IDelegateReference
    {
        public EventWrapper(IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            WrappedObject = @event;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override TDelegateReference EventType
        {
            get { return WrappedObject.EventType; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> WrappedObject { get; private set; }
    }
}
