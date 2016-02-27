using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        AbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TDelegateReference : IDelegateReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> FieldAttributes { get; }

        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassEventChildren(this, visitor);
        }
    }
}
