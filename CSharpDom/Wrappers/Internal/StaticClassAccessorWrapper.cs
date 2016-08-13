using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassAccessorWrapper : AbstractWrapper<IStaticClassAccessor>, IStaticClassAccessorWrapper
    {
        public StaticClassAccessorWrapper(IStaticClassAccessor accessor)
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

        public StaticClassAccessorVisibilityModifier Visibility
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

        public override void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
        }
    }
}
