using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassAccessor<TAttributeGroup, TMethodBody> : 
        AbstractAccessor<TAttributeGroup, TMethodBody>,
        IClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAccessor(this);
        }
    }
}
