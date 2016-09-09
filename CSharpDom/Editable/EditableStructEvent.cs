using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TDelegateReference : IDelegateReference
    {
        public abstract StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructEventChildren(this, visitor);
        }
    }
}
