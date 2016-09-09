using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TDelegateReference : IDelegateReference
    {
        public abstract ICollection<TAttributeGroup> FieldAttributes { get; set; }

        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasFieldAttributes<TAttributeGroup>.FieldAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(FieldAttributes); }
        }

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
