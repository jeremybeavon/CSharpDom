using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IAbstractType
        where TDelegateReference : IDelegateReference
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractEventChildren(this, visitor);
        }
    }
}
