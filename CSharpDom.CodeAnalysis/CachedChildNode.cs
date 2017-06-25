using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedChildNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, TChildSyntax> getSyntax;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax;
        private readonly Func<TChildSyntax, TChildNode> createChildNode;
        private TChildNode cachedChildNode;

        public CachedChildNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TChildSyntax, TChildNode> createChildNode,
            Func<TParentSyntax, TChildSyntax> getSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax)
        {
            this.node = node;
            this.getSyntax = getSyntax;
            this.createSyntax = createSyntax;
            this.createChildNode = createChildNode;
        }

        public CachedChildNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TChildNode> createChildNode,
            Func<TParentSyntax, TChildSyntax> getSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax)
            : this(node, syntax => createChildNode(), getSyntax, createSyntax)
        {
        }

        public TChildNode Value
        {
            get
            {
                TChildNode childNode = createChildNode(getSyntax(node.Syntax));
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

        private void CacheChildNode(TChildNode childNode)
        {
            cachedChildNode = childNode;
            if (cachedChildNode != null)
            {
                cachedChildNode.Node.SetParentNode(node.Value, getSyntax, createSyntax);
            }
        }
    }
}