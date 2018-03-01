using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AbstractIndexerWithReflection :
        AbstractAbstractIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IndexerParameterWithReflection,
            AbstractAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;
        private readonly AbstractAccessorWithReflection getAccessor;
        private readonly AbstractAccessorWithReflection setAccessor;
        
        internal AbstractIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithReflection(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithReflection(this, this.indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override AbstractAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }
        
        public override IReadOnlyList<IndexerParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AbstractAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.AbstractClassVisibility(); }
        }
    }
}
