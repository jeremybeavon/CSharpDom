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
        private readonly int index;
        private object parent;
        private Func<ArrayTypeSyntax> getType;
        private Action<ArrayTypeSyntax> setType;

        internal ArrayTypeReferenceWithCodeAnalysis(GenericParameterWithCodeAnalysis parent)
        {
            GenericParameterParent = parent;
        }

        private ArrayTypeReferenceWithCodeAnalysis(ArrayTypeReferenceWithCodeAnalysis parent, int index)
        {
            this.index = index;
            this.parent = parent;
            getType = () => ((ArrayTypeReferenceWithCodeAnalysis)this.parent).getType();
            setType = syntax => ((ArrayTypeReferenceWithCodeAnalysis)this.parent).setType(syntax);
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
            get { return getType().RankSpecifiers[index].Rank; }
            set
            {
                ArrayTypeSyntax syntax = getType();
                ArrayRankSpecifierSyntax rankSyntax = syntax.RankSpecifiers[index];
                IEnumerable<Func<ExpressionSyntax>> sizes =
                    Enumerable.Repeat<Func<ExpressionSyntax>>(SyntaxFactory.OmittedArraySizeExpression, value);
                ArrayRankSpecifierSyntax newRank = rankSyntax.WithSizes(SyntaxFactory.SeparatedList(sizes.Select(size => size())));
                setType(syntax.WithRankSpecifiers(syntax.RankSpecifiers.Replace(rankSyntax, newRank)));
            }
        }

        public ArrayTypeSyntax Syntax
        {
            get { return getType(); }
        }

        internal GenericParameterWithCodeAnalysis GenericParameterParent
        {
            get { return parent as GenericParameterWithCodeAnalysis; }
            set
            {
                parent = value;
                getType = () => (ArrayTypeSyntax)GenericParameterParent.Syntax;
                setType = syntax => GenericParameterParent.Syntax = syntax;
            }
        }

        private void RefreshElementType()
        {
            int rankCount = getType().RankSpecifiers.Count;
            if (index + 1 == rankCount)
            {
                
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
