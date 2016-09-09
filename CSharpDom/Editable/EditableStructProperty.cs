using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TAccessor : IStructAccessor
    {
        public abstract StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructPropertyChildren(this, visitor);
        }
    }
}
