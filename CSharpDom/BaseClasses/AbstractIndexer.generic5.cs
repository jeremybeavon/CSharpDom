using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IAccessor
    {
        public abstract TAccessor GetAccessor { get; }

        public abstract TAccessor SetAccessor { get; }
        
        public sealed override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
