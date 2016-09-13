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
        private TChildNode cachedValue;

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
                TChildNode newValue = createChildNode(getSyntax(node.Syntax));
                if (cachedValue == null ||
                    (newValue == null && cachedValue != null) ||
                    (newValue != null && newValue.GetType() != cachedValue.GetType()))
                {
                    cachedValue = newValue;
                }

                return cachedValue;
            }
            set
            {
                if (cachedValue != null)
                {
                    cachedValue.Node.RemoveParentNode();
                }

                node.Syntax = createSyntax(node.Syntax, value.Node.Syntax);
                cachedValue = createChildNode(value.Node.Syntax);
                if (cachedValue != null)
                {
                    cachedValue.Node.SetParentNode(node.Value, getSyntax, createSyntax);
                }
            }
        }
    }
}