using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassIndexerWithCodeAnalysis :
        EditableClassIndexer<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>
    {
        private readonly AbstractClassIndexerWithCodeAnalysis indexer;

        public AbstractPartialClassIndexerWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IndexerParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this(new AbstractClassIndexerWithCodeAnalysis(visibility, type, parameters, getAccessor, setAccessor))
        {
        }

        internal AbstractPartialClassIndexerWithCodeAnalysis(AbstractClassIndexerWithCodeAnalysis indexer)
        {
            this.indexer = indexer;
            indexer.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public AbstractClassIndexerWithCodeAnalysis Indexer
        {
            get { return indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.Indexer.Indexer.Indexer.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return indexer.GetAccessor; }
            set { indexer.GetAccessor = value; }

        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
            set { indexer.IndexerType = value; }
        }

        public override IndexerInheritanceModifier InheritanceModifier
        {
            get { return indexer.InheritanceModifier; }
            set { indexer.InheritanceModifier = value; }
        }

        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
            set { indexer.Parameters = value; }
        }

        public override ClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return indexer.SetAccessor; }
            set { indexer.SetAccessor = value; }
        }
        
        public override ClassMemberVisibilityModifier Visibility
        {
            get { return indexer.Visibility; }
            set { indexer.Visibility = value; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }
        
        internal AbstractClassIndexerWithCodeAnalysis InternalIndexer
        {
            get { return indexer; }
        }
    }
}
