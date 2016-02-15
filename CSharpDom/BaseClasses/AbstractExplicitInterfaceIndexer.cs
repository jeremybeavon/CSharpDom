using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractExplicitInterfaceIndexer<
        TAttributeGroup,
        TDeclaringType,
        TInterfaceReference,
        TTypeReference,
        TParameter,
        TAccessor> :
        AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
        public abstract TInterfaceReference ExplicitInterface { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceIndexer(this);
        }
    }
}
