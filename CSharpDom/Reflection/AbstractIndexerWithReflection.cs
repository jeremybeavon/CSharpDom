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
            ParameterWithReflection,
            AbstractAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;

        internal AbstractIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {
            this.indexer = new IndexerWithReflection(declaringType, indexer);
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
            get { throw new NotImplementedException(); }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }
        
        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AbstractAccessorWithReflection SetAccessor
        {
            get { throw new NotImplementedException(); }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.ClassVisibility(); }
        }
    }
}
