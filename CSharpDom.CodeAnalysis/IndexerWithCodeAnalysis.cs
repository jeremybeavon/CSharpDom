using System;
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
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> getAccessor;
        private readonly CachedTypeReferenceNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> indexerType;
        private readonly SeparatedSyntaxListWrapper<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            IndexerParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> setAccessor;

        internal IndexerWithCodeAnalysis()
        {
            node = new Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(this);
            attributes = new AttributeListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            indexerType = new CachedTypeReferenceNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
            parameters = new SeparatedSyntaxListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, IndexerParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                () => new IndexerParameterWithCodeAnalysis());
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
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
        
        internal Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> Node
        {
            get { return node; }
        }
        
        private CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                () => new AccessorWithCodeAnalysis(kind),
                syntax => GetAccessorDeclaration(syntax, kind),
                (parentSyntax, childSyntax) => CreateAccessor(kind)(parentSyntax, childSyntax));
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
