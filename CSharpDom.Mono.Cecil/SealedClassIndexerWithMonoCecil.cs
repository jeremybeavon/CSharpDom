using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassIndexerWithMonoCecil :
        AbstractSealedClassIndexer<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IndexerParameterWithMonoCecil,
            ClassAccessorWithMonoCecil>
    {
        private readonly IndexerWithMonoCecil indexer;
        private readonly IInternalTypeWithMonoCecil declaringType;
        private readonly ClassAccessorWithMonoCecil getAccessor;
        private readonly ClassAccessorWithMonoCecil setAccessor;

        internal SealedClassIndexerWithMonoCecil(IInternalTypeWithMonoCecil declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithMonoCecil(declaringType, indexer);
            this.declaringType = declaringType;
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithMonoCecil(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithMonoCecil(this, this.indexer.SetAccessor);
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

        public override ClassAccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithMonoCecil IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override SealedClassIndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.PropertyInfo.SealedClassIndexerInheritanceModifier(declaringType); }
        }
        
        public override IReadOnlyList<IndexerParameterWithMonoCecil> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override ClassAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.ClassVisibility(); }
        }
    }
}
