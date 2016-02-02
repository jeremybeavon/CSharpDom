using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> : 
        AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract StructMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEventProperty(this);
        }
    }
}
