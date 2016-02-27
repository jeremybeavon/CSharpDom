using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructIndexerWithMonoCecil :
        AbstractStructIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            StructAccessorWithMonoCecil>
    {
        private readonly IndexerWithMonoCecil indexer;
        private readonly StructAccessorWithMonoCecil getAccessor;
        private readonly StructAccessorWithMonoCecil setAccessor;

        internal StructIndexerWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithMonoCecil(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithMonoCecil(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithMonoCecil(this, this.indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override StructAccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithMonoCecil IndexerType
        {
            get { return indexer.IndexerType; }
        }
        
        public override IReadOnlyList<IndexerParameterWithMonoCecil> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override StructAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.StructVisibility(); }
        }
    }
}
