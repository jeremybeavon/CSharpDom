using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedChildNode<TParentNode, TParentSyntax, TChildNode>
        where TParentNode : class
        where TParentSyntax : class
        where TChildNode : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, TChildNode> getValue;
        private readonly Func<TParentSyntax, TChildNode, TParentSyntax> setValue;
        private readonly Action<TChildNode, TParentNode> setParent;
        private TChildNode cachedValue;

        public CachedChildNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TChildNode> getValue,
            Func<TParentSyntax, TChildNode, TParentSyntax> setValue,
            Action<TChildNode, TParentNode> setParent)
        {
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
                    setParent(cachedValue, node.Value);
                }
            }
        }
    }
}