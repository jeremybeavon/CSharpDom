using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassAccessor<TAttributeGroup, TMethodBody> : 
        AbstractAccessor<TAttributeGroup, TMethodBody>,
        ISealedClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract SealedClassMemberVisibilityModifier Visibility { get; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassAccessor(this);
        }
    }
}
