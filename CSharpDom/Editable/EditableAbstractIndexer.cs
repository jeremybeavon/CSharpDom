using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IAbstractType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAbstractAccessor
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractIndexerChildren(this, visitor);
        }
    }
}
