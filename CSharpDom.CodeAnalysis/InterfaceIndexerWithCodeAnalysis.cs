using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceIndexerWithCodeAnalysis :
        EditableInterfaceIndexer<
            AttributeGroupWithCodeAnalysis,
            IInterfaceTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            InterfaceAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly IndexerWithCodeAnalysis indexer;

        internal InterfaceIndexerWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent)
            : this()
        {
            indexer = new IndexerWithCodeAnalysis(parent, this);
        }

        private InterfaceIndexerWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public IndexerWithCodeAnalysis Indexer
        {
            get { return indexer; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return indexer.Attributes; }
            set { indexer.Attributes = value; }
        }

        public override IInterfaceTypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.Node.GetParentNode<IInterfaceTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override InterfaceAccessorWithCodeAnalysis GetAccessor
        {
            get { return new InterfaceAccessorWithCodeAnalysis(indexer.GetAccessor); }
            set { indexer.GetAccessor = value?.Accessor; }
        }
        
        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
            set { indexer.IndexerType = value; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToInterfaceMemberInheritanceModifier(); }
            set { Syntax = Syntax.WithModifiers(value.ToTokens()); }
        }

        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
            set { indexer.Parameters = value; }
        }

        public override InterfaceAccessorWithCodeAnalysis SetAccessor
        {
            get { return new InterfaceAccessorWithCodeAnalysis(indexer.SetAccessor); }
            set { indexer.SetAccessor = value?.Accessor; }
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
