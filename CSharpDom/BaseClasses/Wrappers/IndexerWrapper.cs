using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class IndexerWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> :
        AbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>,
        IWrapper<IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TAccessor : IAccessor
    {
        public IndexerWrapper(IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            WrappedObject = indexer;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override TAccessor GetAccessor
        {
            get { return WrappedObject.GetAccessor; }
        }

        public override TTypeReference IndexerType
        {
            get { return WrappedObject.IndexerType; }
        }

        public override IReadOnlyList<TParameter> Parameters
        {
            get { return WrappedObject.Parameters; }
        }

        public override TAccessor SetAccessor
        {
            get { return WrappedObject.SetAccessor; }
        }

        public IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> WrappedObject { get; private set; }
    }
}
