using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractIndexerWithCodeAnalysis :
        EditableAbstractIndexer<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AbstractAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasNode<IndexerDeclarationSyntax>
    {
        private readonly IndexerWithCodeAnalysis indexer;

        public AbstractIndexerWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IndexerParameterWithCodeAnalysis> parameters,
            AccessorTypes accessors)
            : this()
        {
            var parameterSyntax = parameters.Select(parameter => parameter.Syntax);
            List<AccessorDeclarationSyntax> accessorSyntax = new List<AccessorDeclarationSyntax>();
            if (accessors.HasFlag(AccessorTypes.Get))
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetKeyword));
            }

            if (accessors.HasFlag(AccessorTypes.Set))
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetKeyword));
            }

            Syntax = SyntaxFactory.IndexerDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility).Add(SyntaxKind.AbstractKeyword),
                type.Syntax,
                null,
                SyntaxFactory.BracketedParameterList(SyntaxFactory.SeparatedList(parameterSyntax)),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessorSyntax)));
        }

        internal AbstractIndexerWithCodeAnalysis()
        {
            indexer = new IndexerWithCodeAnalysis();
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

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? indexer.Node.GetParent<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
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

        public override AbstractMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToAbstractMemberVisibilityModifier(); }
            set
            {
                IndexerDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithAbstractMemberVisibilityModifier(value));
            }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }
        
        INode<IndexerDeclarationSyntax> IHasNode<IndexerDeclarationSyntax>.Node
        {
            get { return indexer.Node; }
        }

        internal Func<IAbstractTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
