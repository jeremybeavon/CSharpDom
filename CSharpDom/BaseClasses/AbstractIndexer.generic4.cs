using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter> :
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }
        
        public abstract TTypeReference IndexerType { get; }
        
        public abstract IReadOnlyList<TParameter> Parameters { get; }
        
        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
