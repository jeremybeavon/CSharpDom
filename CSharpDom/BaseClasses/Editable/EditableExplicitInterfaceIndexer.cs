using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableExplicitInterfaceIndexer<
        TAttributeGroup,
        TDeclaringType,
        TInterfaceReference,
        TTypeReference,
        TParameter,
        TAccessor> :
        EditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
        public abstract TInterfaceReference ExplicitInterface { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExplicitInterfaceIndexerChildren(this, visitor);
        }
    }
}
