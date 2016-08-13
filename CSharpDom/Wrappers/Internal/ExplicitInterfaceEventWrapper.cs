using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceEventWrapper : AbstractWrapper<IExplicitInterfaceEvent>, IExplicitInterfaceEventWrapper
    {
        public ExplicitInterfaceEventWrapper(IExplicitInterfaceEvent eventProperty)
            : base(eventProperty)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> AddAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper AddBody
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeWrapper DeclaringType
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

        public IInterfaceReferenceWrapper ExplicitInterface
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

        public IReadOnlyCollection<IAttributeGroupWrapper> RemoveAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper RemoveBody
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

        public override void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
        {
        }
    }
}
