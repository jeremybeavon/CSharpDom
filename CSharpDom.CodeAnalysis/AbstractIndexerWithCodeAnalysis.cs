using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractIndexerWithCodeAnalysis :
        EditableAbstractIndexer<
            AttributeGroupWithCodeAnalysis,
            IAbstractType,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AbstractAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly IndexerWithCodeAnalysis indexer;
        
        internal AbstractIndexerWithCodeAnalysis(ClassTypeWithCodeAnalysis parent)
            : this()
        {
            indexer = new IndexerWithCodeAnalysis(parent, this);
        }

        private AbstractIndexerWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        internal IndexerWithCodeAnalysis Indexer
        {
            get { return indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; }
        }

        public override AbstractAccessorWithCodeAnalysis GetAccessor
        {
            get { return new AbstractAccessorWithCodeAnalysis(indexer.GetAccessor); }
            set { indexer.GetAccessor = value?.Accessor; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
            set { indexer.IndexerType = value; }
        }
        
        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
            set { indexer.Parameters = value; }
        }

        public override AbstractAccessorWithCodeAnalysis SetAccessor
        {
            get { return new AbstractAccessorWithCodeAnalysis(indexer.SetAccessor); }
            set { indexer.SetAccessor = value?.Accessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                IndexerDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }
        
        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
