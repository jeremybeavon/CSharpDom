using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassIndexerWithCodeAnalysis :
        AbstractSealedClassIndexer<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>
    {
        private readonly IndexerWithCodeAnalysis indexer;
        private readonly IInternalTypeWithCodeAnalysis declaringType;
        private readonly ClassAccessorWithCodeAnalysis getAccessor;
        private readonly ClassAccessorWithCodeAnalysis setAccessor;

        internal SealedClassIndexerWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, PropertyDefinition indexer)
        {
            this.indexer = new IndexerWithCodeAnalysis(declaringType, indexer);
            this.declaringType = declaringType;
            if (this.indexer.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithCodeAnalysis(this, this.indexer.GetAccessor);
            }

            if (this.indexer.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithCodeAnalysis(this, this.indexer.SetAccessor);
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

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
        }

        public override SealedClassIndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.PropertyDefinition.SealedClassIndexerInheritanceModifier(declaringType); }
        }
        
        public override IReadOnlyList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
        }

        public override ClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.PropertyDefinition.ClassVisibility(); }
        }
    }
}
