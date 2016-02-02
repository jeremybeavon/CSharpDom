using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEvent(this);
        }
    }
}
