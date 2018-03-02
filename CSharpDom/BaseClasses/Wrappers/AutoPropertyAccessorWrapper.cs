using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class AutoPropertyAccessorWrapper<TAttributeGroup> :
        AbstractAutoPropertyAccessor<TAttributeGroup>,
        IWrapper<IAutoPropertyAccessor<TAttributeGroup>>
        where TAttributeGroup : IAttributeGroup
    {
        public AutoPropertyAccessorWrapper(IAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            WrappedObject = accessor;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }
        
        public IAutoPropertyAccessor<TAttributeGroup> WrappedObject { get; private set; }
    }
}
