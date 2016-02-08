using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassAccessor<TAttributeGroup, TMethodBody> : 
        AbstractAccessor<TAttributeGroup, TMethodBody>,
        IStaticClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassAccessor(this);
        }
    }
}
