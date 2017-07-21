using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassIndexerWithCodeAnalysis :
        EditableClassIndexer<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            ClassAccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        IHasNode<IndexerDeclarationSyntax>
    {
        private readonly IndexerWithBodyWithCodeAnalysis indexer;

        public ClassIndexerWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
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
                default(SyntaxTokenList).WithClassMemberVisibilityModifier(visibility),
                type.Syntax,
                null,
                SyntaxFactory.BracketedParameterList(SyntaxFactory.SeparatedList(parameterSyntax)),
                SyntaxFactory.AccessorList(SyntaxFactory.List(accessorSyntax)));
        }

        internal ClassIndexerWithCodeAnalysis()
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

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return indexer.Indexer.Node.GetParentNode<IClassTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ClassAccessorWithCodeAnalysis GetAccessor
        {
            get { return new ClassAccessorWithCodeAnalysis(indexer.GetAccessor); }
            set { indexer.GetAccessor = value?.Accessor; }

        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexer.IndexerType; }
            set { indexer.IndexerType = value; }
        }

        public override IndexerInheritanceModifier InheritanceModifier
        {
            get { return Syntax.Modifiers.ToIndexerInheritanceModifier(); }
            set
            {
                IndexerDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithIndexerInheritanceModifier(value));
            }
        }

        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return indexer.Parameters; }
            set { indexer.Parameters = value; }
        }

        public override ClassAccessorWithCodeAnalysis SetAccessor
        {
            get { return new ClassAccessorWithCodeAnalysis(indexer.SetAccessor); }
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

        INode<IndexerDeclarationSyntax> IHasNode<IndexerDeclarationSyntax>.Node
        {
            get { return indexer.Indexer.Node; }
        }
    }
}
