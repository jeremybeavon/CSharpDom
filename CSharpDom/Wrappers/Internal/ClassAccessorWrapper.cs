using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassAccessorWrapper : AbstractWrapper<IClassAccessor>, IClassAccessorWrapper
    {
        public ClassAccessorWrapper(IClassAccessor accessor)
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

        public ClassAccessorVisibilityModifier Visibility
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

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(
            IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            
        }
    }
}
