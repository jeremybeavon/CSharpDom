using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalListWrapperBuilder<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TChildNode : IHasParent<TChildNode, TChildSyntax>
    {
        private readonly Func<TChildSyntax, TChildNode> createItem;
        private readonly Func<TParentNode, IChildCollection<TChildNode, TChildSyntax>> getCollection;

        public InternalListWrapperBuilder(

            Func<TChildSyntax, TChildNode> createItem,
            Func<TParentNode, IChildCollection<TChildNode, TChildSyntax>> getCollection)
        {
            this.createItem = createItem;
            this.getCollection = getCollection;
        }

        public TChildNode CreateItem(TParentNode parent, TChildSyntax childSyntax)
        {
            TChildNode item = createItem(childSyntax);
            SetParent(item, parent);
            return item;
        }

        public void SetParent(TChildNode child, TParentNode parent)
        {
            child.SetParentNode<TParentNode, TParentSyntax>(parent, getCollection);
        }
    }
}
