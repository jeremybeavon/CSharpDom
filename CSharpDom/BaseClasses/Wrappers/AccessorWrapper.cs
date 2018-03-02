using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class AccessorWrapper<TAttributeGroup> :
        AbstractAccessor<TAttributeGroup>,
        IWrapper<IAccessor<TAttributeGroup>>
        where TAttributeGroup : IAttributeGroup
    {
        public AccessorWrapper(IAccessor<TAttributeGroup> accessor)
        {
            WrappedObject = accessor;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }
        
        public IAccessor<TAttributeGroup> WrappedObject { get; private set; }
    }
}
