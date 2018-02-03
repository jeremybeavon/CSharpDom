using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedChildNode<TParent, TParentSyntax, TChild, TChildSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, TChildSyntax> getSyntax;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax;
        private readonly Func<TChildSyntax, TChild> createChildNode;
        private TChild cachedChildNode;

        public CachedChildNode(
            Node<TParent, TParentSyntax> node,
            Func<TChildSyntax, TChild> createChildNode,
            Func<TParentSyntax, TChildSyntax> getSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax)
        {
            this.node = node;
            this.getSyntax = getSyntax;
            this.createSyntax = createSyntax;
            this.createChildNode = createChildNode;
        }

        public CachedChildNode(
            Node<TParent, TParentSyntax> node,
            Func<TChild> createChildNode,
            Func<TParentSyntax, TChildSyntax> getSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax)
            : this(node, syntax => syntax == null ? null : createChildNode(), getSyntax, createSyntax)
        {
        }

        public TChild Value
        {
            get
            {
                TChild childNode = createChildNode(getSyntax(node.Syntax));
                if (cachedChildNode == null ||
                    (childNode == null && cachedChildNode != null) ||
                    (childNode != null && childNode.GetType() != cachedChildNode.GetType()))
                {
                    CacheChildNode(childNode);
                }

                return cachedChildNode;
            }
            set
            {
                if (cachedChildNode != null)
                {
                    cachedChildNode.Node.RemoveParentNode();
                }

                node.Syntax = createSyntax(node.Syntax, value.Node.Syntax);
                CacheChildNode(createChildNode(value.Node.Syntax));
            }
        }

        private void CacheChildNode(TChild childNode)
        {
            cachedChildNode = childNode;
            if (cachedChildNode != null)
            {
                cachedChildNode.Node.SetParent(node.Value, getSyntax, createSyntax);
            }
        }
    }
}