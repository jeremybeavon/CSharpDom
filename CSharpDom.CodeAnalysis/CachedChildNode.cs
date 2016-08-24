using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class CachedChildNode<TParentNode, TChildNode, TChildSyntax>
        where TParentNode : class
        where TChildNode : class
        where TChildSyntax : class
    {
        private readonly TParentNode parent;
        private readonly Node<TChildNode, TChildSyntax> node;
        private readonly Func<TChildSyntax, TChildNode> getValue;
        private readonly Func<TChildSyntax, TChildNode, TChildSyntax> setValue;
        private readonly Action<TChildNode, TParentNode> setParent;
        private TChildNode cachedValue;

        public CachedChildNode(
            TParentNode parent,
            Node<TChildNode, TChildSyntax> node,
            Func<TChildSyntax, TChildNode> getValue,
            Func<TChildSyntax, TChildNode, TChildSyntax> setValue,
            Action<TChildNode, TParentNode> setParent)
        {
            this.parent = parent;
            this.node = node;
            this.getValue = getValue;
            this.setValue = setValue;
            this.setParent = setParent;
        }

        public TChildNode Value
        {
            get
            {
                TChildNode newValue = getValue(node.Syntax);
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

                node.Syntax = setValue(node.Syntax, value);
                cachedValue = getValue(node.Syntax);
                if (cachedValue != null)
                {
                    setParent(cachedValue, parent);
                }
            }
        }
    }
}