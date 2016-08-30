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
        private readonly Func<TParentNode, TChildNode> getValue;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> setValue;
        private readonly Action<TChildNode, TParentNode> setParent;
        private TChildNode cachedValue;

        public CachedChildNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentNode, TChildNode> getValue,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> setValue,
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

                node.Syntax = setValue(node.Syntax, value?.Syntax);
                cachedValue = getValue(node.Value);
                if (cachedValue != null)
                {
                    setParent(cachedValue, node.Value);
                }
            }
        }
    }
}