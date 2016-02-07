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
            ParameterWithReflection,
            ClassAccessorWithReflection>
    {
        private readonly IndexerWithReflection indexer;

        internal StructIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
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

        public override ClassAccessorWithReflection GetAccessor
        {
            get { return indexer.GetAccessor; }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get { return indexer.IndexerType; }
        }
        
        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override ClassAccessorWithReflection SetAccessor
        {
            get { return indexer.SetAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyInfo.StructVisibility(); }
        }
    }
}
