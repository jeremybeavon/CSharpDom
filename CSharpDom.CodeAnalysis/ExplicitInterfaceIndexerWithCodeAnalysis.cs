﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceIndexerWithCodeAnalysis :
        EditableExplicitInterfaceIndexer<
            AttributeGroupWithCodeAnalysis,
            IType,
            InterfaceReferenceWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithBodyWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasNode<IndexerDeclarationSyntax>
    {
        private readonly IndexerWithBodyWithCodeAnalysis indexer;
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            InterfaceReferenceWithCodeAnalysis,
            NameSyntax> explicitInterface;

        internal ExplicitInterfaceIndexerWithCodeAnalysis()
        {
            indexer = new IndexerWithBodyWithCodeAnalysis();
            explicitInterface = new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>(
                indexer.Indexer.Node,
                () => new InterfaceReferenceWithCodeAnalysis(new UnspecifiedTypeReferenceWithCodeAnalysis()),
                syntax => syntax.ExplicitInterfaceSpecifier.Name,
                (parentSyntax, childSyntax) => parentSyntax.WithExplicitInterfaceSpecifier(parentSyntax.ExplicitInterfaceSpecifier.WithName(childSyntax)));
        }

        public IndexerWithBodyWithCodeAnalysis Indexer
        {
            get { return indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; }
        }

        public override IType DeclaringType
        {
            get { return indexer.Indexer.Node.GetParent<IType>(); }
            set { throw new NotSupportedException(); }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface.Value; }
            set { explicitInterface.Value = value; }
        }

        public override AccessorWithBodyWithCodeAnalysis GetAccessor
        {
            get { return indexer.GetAccessor; }
            set { indexer.GetAccessor = value; }
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

        public override AccessorWithBodyWithCodeAnalysis SetAccessor
        {
            get { return indexer.SetAccessor; }
            set { indexer.SetAccessor = value; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }
        
        INode<IndexerDeclarationSyntax> IHasNode<IndexerDeclarationSyntax>.Node
        {
            get { return indexer.Indexer.Node; }
        }
    }
}
