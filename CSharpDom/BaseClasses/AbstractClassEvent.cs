using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> FieldAttributes { get; }

        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEvent(this);
        }
    }
}
