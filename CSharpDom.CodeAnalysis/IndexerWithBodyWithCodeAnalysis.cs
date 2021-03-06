﻿using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class IndexerWithBodyWithCodeAnalysis :
        EditableIndexer<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithBodyWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>
    {
        private readonly IndexerWithCodeAnalysis indexer;

        internal IndexerWithBodyWithCodeAnalysis()
        {
            this.indexer = new IndexerWithCodeAnalysis();
        }
        
        public IndexerWithCodeAnalysis Indexer
        {
            get { return indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; ; }
        }

        public override IBasicType DeclaringType
        {
            get { return indexer.Node.GetParent<IBasicType>(); }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithBodyWithCodeAnalysis GetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = indexer.GetAccessor;
                return accessor == null ? null : new AccessorWithBodyWithCodeAnalysis(accessor);
            }
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

        public override AccessorWithBodyWithCodeAnalysis SetAccessor
        {
            get
            {
                AccessorWithCodeAnalysis accessor = indexer.SetAccessor;
                return accessor == null ? null : new AccessorWithBodyWithCodeAnalysis(accessor);
            }
            set { indexer.SetAccessor = value?.Accessor; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }
    }
}
