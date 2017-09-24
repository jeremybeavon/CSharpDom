using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructIndexerWithCodeAnalysis :
        EditableStructIndexer<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            StructAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasNode<IndexerDeclarationSyntax>
    {
        private readonly IndexerWithBodyWithCodeAnalysis indexer;

        public StructIndexerWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            IEnumerable<IndexerParameterWithCodeAnalysis> parameters,
            MethodBodyWithCodeAnalysis getAccessor,
            MethodBodyWithCodeAnalysis setAccessor)
            : this()
        {
            var parameterSyntax = parameters.Select(parameter => parameter.Syntax);
            List<AccessorDeclarationSyntax> accessorSyntax = new List<AccessorDeclarationSyntax>();
            if (getAccessor != null)
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.GetKeyword, getAccessor.Syntax));
            }

            if (setAccessor != null)
            {
                accessorSyntax.Add(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetKeyword, setAccessor.Syntax));
            }

            Syntax = SyntaxFactory.IndexerDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility),
                type.Syntax,
                null,
                SyntaxFactory.BracketedParameterList(SyntaxFactory.SeparatedList(parameterSyntax)),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessorSyntax)));
        }

        internal StructIndexerWithCodeAnalysis()
        {
            indexer = new IndexerWithBodyWithCodeAnalysis();
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? indexer.Indexer.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override StructAccessorWithCodeAnalysis GetAccessor
        {
            get
            {
                AccessorWithBodyWithCodeAnalysis accessor = indexer.GetAccessor;
                return accessor == null ? null : new StructAccessorWithCodeAnalysis(accessor);
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

        public override StructAccessorWithCodeAnalysis SetAccessor
        {
            get
            {
                AccessorWithBodyWithCodeAnalysis accessor = indexer.SetAccessor;
                return accessor == null ? null : new StructAccessorWithCodeAnalysis(accessor);
            }
            set { indexer.SetAccessor = value?.Accessor; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return indexer.Syntax; }
            set { indexer.Syntax = value; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                IndexerDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }
        
        INode<IndexerDeclarationSyntax> IHasNode<IndexerDeclarationSyntax>.Node
        {
            get { return indexer.Indexer.Node; }
        }

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
