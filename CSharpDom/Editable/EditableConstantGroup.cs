using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual IReadOnlyCollection<TConstant> Constants { get; set; }

        public virtual TTypeReference FieldType { get; set; }
        
        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstantGroup(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstantGroupChildren(this, visitor);
        }
    }
}
