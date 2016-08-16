using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractIndexerWithCodeAnalysis :
        AbstractAbstractIndexer<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AbstractAccessorWithCodeAnalysis>
    {
        private readonly IndexerWithCodeAnalysis indexer;
        private readonly AbstractAccessorWithCodeAnalysis getAccessor;
        private readonly AbstractAccessorWithCodeAnalysis setAccessor;
        
        internal AbstractIndexerWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithCodeAnalysis(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithCodeAnalysis(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithCodeAnalysis(this, this.indexer.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.DeclaringType; }
        }

        public override AbstractAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
        }
        
        public override IReadOnlyList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override AbstractAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyDefinition.ClassVisibility(); }
        }
    }
}
