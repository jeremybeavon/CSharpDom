using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceEventWrapper : AbstractWrapper<IInterfaceEvent>, IInterfaceEventWrapper
    {
        public InterfaceEventWrapper(IInterfaceEvent @event)
            : base(@event)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IInterfaceTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDelegateReferenceWrapper EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
        }
    }
}
