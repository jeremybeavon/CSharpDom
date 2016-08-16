using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
        public virtual IReadOnlyCollection<TAttributeGroup> FieldAttributes { get; set; }

        public virtual SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassEventChildren(this, visitor);
        }
    }
}
