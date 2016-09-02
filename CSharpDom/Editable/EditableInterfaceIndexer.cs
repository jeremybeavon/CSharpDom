using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IInterfaceAccessor
    {
        public virtual InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceIndexerChildren(this, visitor);
        }
    }
}
