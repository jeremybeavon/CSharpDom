using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassIndexerWithMonoCecil :
        AbstractClassIndexer<
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

        internal ClassIndexerWithMonoCecil(IInternalTypeWithMonoCecil declaringType, PropertyDefinition indexer)
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

        public override IndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.PropertyDefinition.IndexerInheritanceModifier(declaringType); }
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
            get { return indexer.PropertyDefinition.ClassVisibility(); }
        }
    }
}
