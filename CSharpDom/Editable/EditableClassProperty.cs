using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassPropertyChildren(this, visitor);
        }
    }
}
