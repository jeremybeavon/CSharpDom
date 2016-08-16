using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructIndexerWithCodeAnalysis :
        AbstractStructIndexer<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            StructAccessorWithCodeAnalysis>
    {
        private readonly IndexerWithCodeAnalysis indexer;
        private readonly StructAccessorWithCodeAnalysis getAccessor;
        private readonly StructAccessorWithCodeAnalysis setAccessor;

        internal StructIndexerWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithCodeAnalysis(declaringType, indexer);
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithCodeAnalysis(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithCodeAnalysis(this, this.indexer.SetAccessor);
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

        public override StructAccessorWithCodeAnalysis GetAccessor
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

        public override StructAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyDefinition.StructVisibility(); }
        }
    }
}
