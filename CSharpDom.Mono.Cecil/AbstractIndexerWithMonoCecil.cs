using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractIndexerWithMonoCecil :
        AbstractAbstractIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            AbstractAccessorWithMonoCecil>
    {
        private readonly IndexerWithMonoCecil indexer;
        private readonly AbstractAccessorWithMonoCecil getAccessor;
        private readonly AbstractAccessorWithMonoCecil setAccessor;
        
        internal AbstractIndexerWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithMonoCecil(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithMonoCecil(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithMonoCecil(this, this.indexer.SetAccessor);
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

        public override AbstractAccessorWithMonoCecil GetAccessor
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

        public override AbstractAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyDefinition.AbstractClassVisibility(); }
        }
    }
}
