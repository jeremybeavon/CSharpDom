using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TDelegateReference : IDelegateReference
    {
        public virtual ICollection<TAttributeGroup> FieldAttributes { get; set; }

        public virtual ClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasFieldAttributes<TAttributeGroup>.FieldAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(FieldAttributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassEventChildren(this, visitor);
        }
    }
}
