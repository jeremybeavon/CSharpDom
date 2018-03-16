using System;

namespace CSharpDom.CodeAnalysis
{
    internal class WrappedChildSyntaxList<TParentSyntax, TChildSyntax, TChildChildSyntax> :
        WrappedList<TChildSyntax, TChildChildSyntax>,
        IChildSyntaxList<TParentSyntax, TChildChildSyntax>
        where TChildChildSyntax : class
    {
        private readonly IChildSyntaxList<TParentSyntax, TChildSyntax> list;
        private readonly Func<TChildChildSyntax, TChildSyntax> toParent;

        public WrappedChildSyntaxList(
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChildSyntax, TChildChildSyntax> toChild,
            Func<TChildChildSyntax, TChildSyntax> toParent,
            Func<TChildChildSyntax, bool> filter = null)
            : base(list, toChild, toParent, filter)
        {
            this.list = list;
            this.toParent = toParent;
        }

        public WrappedChildSyntaxList(
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            IWrappedListConversions<TChildSyntax, TChildChildSyntax> conversions,
            Func<TChildChildSyntax, bool> filter = null)
            : this(list, conversions.ToChild, conversions.ToParent, filter)
        {
        }

        public TParentSyntax Set(int index, TChildChildSyntax value)
        {
            int parentIndex = list.IndexOf(toParent(this[index]));
            if (parentIndex < 0)
            {
                throw new InvalidOperationException();
            }

            return list.Set(parentIndex, toParent(value));
        }
    }
}
