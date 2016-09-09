using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructEventProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructEventPropertyChildren(this, visitor);
        }
    }
}
