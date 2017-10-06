using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassPropertyChildren(this, visitor);
        }
    }
}
