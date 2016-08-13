using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceAccessorWrapper : AbstractWrapper<IInterfaceAccessor>, IInterfaceAccessorWrapper
    {
        public InterfaceAccessorWrapper(IInterfaceAccessor accessor)
            : base(accessor)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
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

        public override void VisitInterfaceAccessor<TAttributeGroup>(
            IInterfaceAccessor<TAttributeGroup> accessor)
        {
        }
    }
}
