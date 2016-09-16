using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassIndexerWithCodeAnalysis :
        EditableSealedClassIndexer<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasNode<IndexerDeclarationSyntax>
    {
        private readonly ClassIndexerWithCodeAnalysis indexer;
        
        internal SealedClassIndexerWithCodeAnalysis()
        {
            indexer = new ClassIndexerWithCodeAnalysis();
        }
        
        public IndexerWithBodyWithCodeAnalysis Indexer
        {
            get { return indexer.Indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; }
        }

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.Indexer.Indexer.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
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

        public override SealedClassIndexerInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToSealedClassIndexerInheritanceModifier(); }
            set
            {
                IndexerDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithSealedClassIndexerInheritanceModifier(value));
            }
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
        
        INode<IndexerDeclarationSyntax> IHasNode<IndexerDeclarationSyntax>.Node
        {
            get { return indexer.Indexer.Indexer.Node; }
        }
    }
}
