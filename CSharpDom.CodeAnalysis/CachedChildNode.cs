using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedChildNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class
        where TParentSyntax : class
        where TChildNode : class, IHasSyntax<TChildSyntax>
        where TChildSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax;
        private readonly Func<TParentNode, TChildNode> getValue;
        private readonly Action<TChildNode, TParentNode> setParent;
        private TChildNode cachedValue;

        public CachedChildNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax,
            Func<TParentNode, TChildNode> getValue,
            Action<TChildNode, TParentNode> setParent)
        {
            this.node = node;
            this.getValue = getValue;
            this.createSyntax = createSyntax;
            this.setParent = setParent;
        }

        public TChildNode Value
        {
            get
            {
                TChildNode newValue = getValue(node.Value);
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
                    setParent(cachedValue, null);
                }

                node.Syntax = createSyntax(node.Syntax, value?.Syntax);
                cachedValue = getValue(node.Value);
                if (cachedValue != null)
                {
                    setParent(cachedValue, node.Value);
                }
            }
        }
    }
}