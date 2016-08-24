using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ArrayTypeReferenceWithCodeAnalysis :
        EditableArrayTypeReference<ITypeReferenceWithCodeAnalysis>,
        ITypeReferenceWithCodeAnalysis,
        IHasSyntax<ArrayTypeSyntax>
    {
        private readonly Node<ArrayTypeSyntax> node;
        private readonly ValueNode<ArrayTypeSyntax, int> dimensions;
        private readonly int index;

        internal ArrayTypeReferenceWithCodeAnalysis(GenericParameterWithCodeAnalysis parent)
        {
            GenericParameterParent = parent;
        }

        private ArrayTypeReferenceWithCodeAnalysis(ArrayTypeReferenceWithCodeAnalysis parent, int index)
        {
            this.index = index;
        }

        private ArrayTypeReferenceWithCodeAnalysis()
        {
            node = new Node<ArrayTypeSyntax>();
            dimensions = new ValueNode<ArrayTypeSyntax, int>(node, syntax => syntax.RankSpecifiers[index].Rank, SetDimensions);
        }

        public override ITypeReferenceWithCodeAnalysis ElementType
        {
            get
            {
                RefreshElementType();
                return base.ElementType;
            }
            set
            {
                base.ElementType = value;
            }
        }

        public override int Dimensions
        {
            get { return dimensions.Value; }
            set { dimensions.Value = value; }
        }

        public ArrayTypeSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal GenericParameterWithCodeAnalysis GenericParameterParent
        {
            get { return node.GetParentNode<GenericParameterWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<GenericParameterWithCodeAnalysis, TypeSyntax>(
                    value,
                    syntax => syntax as ArrayTypeSyntax,
                    (parentSyntax, syntax) => value.Syntax = syntax);
            }
        }

        private ArrayTypeSyntax SetDimensions(ArrayTypeSyntax syntax, int value)
        {
            ArrayRankSpecifierSyntax rankSyntax = syntax.RankSpecifiers[index];
            IEnumerable<Func<ExpressionSyntax>> sizes =
                Enumerable.Repeat<Func<ExpressionSyntax>>(SyntaxFactory.OmittedArraySizeExpression, value);
            ArrayRankSpecifierSyntax newRank = rankSyntax.WithSizes(SyntaxFactory.SeparatedList(sizes.Select(size => size())));
            return syntax.WithRankSpecifiers(syntax.RankSpecifiers.Replace(rankSyntax, newRank));
        }

        private void RefreshElementType()
        {
            int rankCount = node.Syntax.RankSpecifiers.Count;
            if (index + 1 == rankCount)
            {
                //base.ElementType = getType().ElementType.ToChildReference(new ChildReference<TParent, ITypeReferenceWithCodeAnalysis>())
            }
            else if (index > rankCount)
            {
                throw new NotSupportedException();
            }
            else if (!(base.ElementType is ArrayTypeReferenceWithCodeAnalysis))
            {
                base.ElementType = new ArrayTypeReferenceWithCodeAnalysis(this, index + 1);
            }
        }
    }
}
