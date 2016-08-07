using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructAccessor<TAttributeGroup, TMethodBody> : 
        AbstractAccessor<TAttributeGroup, TMethodBody>,
        IStructAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        
        public abstract StructAccessorVisibilityModifier Visibility { get; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructAccessor(this);
        }
    }
}
