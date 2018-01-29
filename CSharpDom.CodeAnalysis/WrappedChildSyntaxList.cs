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

        public TParentSyntax Set(int index, TChildChildSyntax value)
        {
            return list.Set(index, toParent(value));
        }
    }
}
