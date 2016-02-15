using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StructIndexerWithReflection :
        AbstractStructIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IndexerParameterWithReflection,
            StructAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;
        private readonly StructAccessorWithReflection getAccessor;
        private readonly StructAccessorWithReflection setAccessor;

        internal StructIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithReflection(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithReflection(this, this.indexer.SetAccessor);
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

        public override StructAccessorWithReflection GetAccessor
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

        public override StructAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.StructVisibility(); }
        }
    }
}
