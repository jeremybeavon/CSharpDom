using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public virtual ClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEventProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassEventPropertyChildren(this, visitor);
        }
    }
}
