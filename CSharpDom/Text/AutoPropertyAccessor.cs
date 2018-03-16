using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Text
{
    internal sealed class AutoPropertyAccessor<TAttributeGroup> : AbstractAccessor<TAttributeGroup, IMethodBody>
        where TAttributeGroup : IAttributeGroup
    {
        private readonly IAutoPropertyAccessor<TAttributeGroup> accessor;

        public AutoPropertyAccessor(IAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            this.accessor = accessor;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes => accessor.Attributes;

        public override IMethodBody Body => null;
    }
}
