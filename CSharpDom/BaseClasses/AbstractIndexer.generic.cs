using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        AbstractGenericVisitableObject,
        IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IIndexerParameter
        where TAccessor : IAccessor
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TAccessor GetAccessor { get; }

        public abstract TTypeReference IndexerType { get; }

        public abstract IReadOnlyList<TParameter> Parameters { get; }

        public abstract TAccessor SetAccessor { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitIndexer(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitIndexerChildren(this, visitor);
        }
    }
}
