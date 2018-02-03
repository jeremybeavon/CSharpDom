using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ArrayTypeReferenceWithCodeAnalysis :
        EditableArrayTypeReference<ITypeReferenceWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<ArrayTypeSyntax>,
        IHasNode<ArrayTypeSyntax>,
        IInternalTypeReferenceWithCodeAnalysis
    {
        private readonly TypeReferenceNode<ArrayTypeReferenceWithCodeAnalysis, ArrayTypeSyntax> node;
        private readonly CachedTypeReferenceNode<ArrayTypeReferenceWithCodeAnalysis, ArrayTypeSyntax> elementType;
        private readonly int index;

        internal ArrayTypeReferenceWithCodeAnalysis()
        {
            node = new TypeReferenceNode<ArrayTypeReferenceWithCodeAnalysis, ArrayTypeSyntax>(this);
            elementType = new CachedTypeReferenceNode<ArrayTypeReferenceWithCodeAnalysis, ArrayTypeSyntax>(
                node,
                syntax => syntax.ElementType,
                (parentSyntax, childSyntax) => parentSyntax.WithElementType(childSyntax));
        }

        private ArrayTypeReferenceWithCodeAnalysis(int index)
            : this()
        {
            this.index = index;
        }

        public override ITypeReferenceWithCodeAnalysis ElementType
        {
            get { return elementType.Value; }
            set { elementType.Value = value; }
        }

        public string Name => ElementType.Name;

        public override int Dimensions
        {
            get { return node.Syntax.RankSpecifiers[index].Rank; }
            set
            {
                ArrayTypeSyntax syntax = node.Syntax;
                ArrayRankSpecifierSyntax rankSyntax = syntax.RankSpecifiers[index];
                IEnumerable<Func<ExpressionSyntax>> sizes =
                    Enumerable.Repeat<Func<ExpressionSyntax>>(SyntaxFactory.OmittedArraySizeExpression, value);
                ArrayRankSpecifierSyntax newRank = rankSyntax.WithSizes(SyntaxFactory.SeparatedList(sizes.Select(size => size())));
                node.Syntax = syntax.WithRankSpecifiers(syntax.RankSpecifiers.Replace(rankSyntax, newRank));
            }
        }

        public ArrayTypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        TypeSyntax IHasSyntax<TypeSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ArrayTypeSyntax)value; }
        }

        private IInternalTypeReferenceWithCodeAnalysis CreateElementType(TypeSyntax syntax)
        {
            int rankCount = node.Syntax.RankSpecifiers.Count;
            if (index + 1 == rankCount)
            {
                return syntax.ToTypeReference();
            }

            if (index > rankCount)
            {
                throw new NotSupportedException();
            }

            return new ArrayTypeReferenceWithCodeAnalysis(index + 1);
        }

        INode<TypeSyntax> IHasNode<TypeSyntax>.Node => node;

        INode<ArrayTypeSyntax> IHasNode<ArrayTypeSyntax>.Node => node;
    }
}
