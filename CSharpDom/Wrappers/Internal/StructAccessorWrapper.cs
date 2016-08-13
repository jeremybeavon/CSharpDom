using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructAccessorWrapper : AbstractWrapper<IStructAccessor>, IStructAccessorWrapper
    {
        public StructAccessorWrapper(IStructAccessor accessor)
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

        public IMethodBodyWrapper Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StructAccessorVisibilityModifier Visibility
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

        public override void VisitStructAccessor<TAttributeGroup, TMethodBody>(
            IStructAccessor<TAttributeGroup, TMethodBody> accessor)
        {
        }
    }
}
