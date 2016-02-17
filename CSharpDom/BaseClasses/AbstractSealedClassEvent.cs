using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> FieldAttributes { get; }

        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
