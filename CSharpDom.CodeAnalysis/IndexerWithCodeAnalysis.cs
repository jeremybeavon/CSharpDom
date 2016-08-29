﻿using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class IndexerWithCodeAnalysis :
        EditableIndexer<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>
    {
        private readonly Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> node;
        private readonly AttributeListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> attributes;
        private readonly CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis> getAccessor;
        private readonly CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, ITypeReferenceWithCodeAnalysis> indexerType;
        private readonly SeparatedSyntaxListWrapper<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            IndexerParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis> setAccessor;

        private IndexerWithCodeAnalysis(IBasicType declaringType)
        {
            node = new Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(this);
            base.DeclaringType = declaringType;
            attributes = new AttributeListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.IndexerParent = parent);
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            indexerType = new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, ITypeReferenceWithCodeAnalysis>(
                node,
                parent => parent.Syntax.Type.ToTypeReference(),
                null,
                null);
            parameters = new SeparatedSyntaxListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, IndexerParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                parent => new IndexerParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.IndexerParent = parent);
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { Syntax = Syntax.WithAttributeLists(value.ToAttributes()); }
        }

        public override IBasicType DeclaringType
        {
            get { return base.DeclaringType; }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor.Value; }
            set { getAccessor.Value = value; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexerType.Value; }
            set { indexerType.Value = value; }
        }

        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.BracketedParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor.Value; }
            set { setAccessor.Value = value; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<IndexerParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return parameters; }
        }

        private CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis>(
                node,
                parent => GetAccessorDeclaration(parent.Syntax, kind) == null ? null : new AccessorWithCodeAnalysis(this, kind),
                (parent, child) => CreateAccessor(kind)(parent.Syntax, GetAccessorDeclaration(parent.Syntax, kind)),
                (child, parent) => child.IndexerParent = parent);
        }

        internal static Func<IndexerDeclarationSyntax, AccessorDeclarationSyntax, IndexerDeclarationSyntax> CreateAccessor(
            SyntaxKind kind)
        {
            return (IndexerDeclarationSyntax parentSyntax, AccessorDeclarationSyntax childSyntax) =>
                parentSyntax.WithAccessorList(parentSyntax.AccessorList.WithAccessor(childSyntax, kind));
        }

        internal static AccessorDeclarationSyntax GetAccessorDeclaration(IndexerDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.GetAccessorDeclaration(kind);
        }
    }
}
