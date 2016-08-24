using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class CachedValueNode<TSyntax, TValue>
        where TSyntax : class
        where TValue : class
    {
        private readonly ValueNode<TSyntax, TValue> node;
        private TValue cachedValue;

        public CachedValueNode(
            Node<TSyntax> node,
            Func<TSyntax, TValue> getValue,
            Func<TSyntax, TValue, TSyntax> setValue)
        {
            this.node = new ValueNode<TSyntax, TValue>(node, getValue, setValue);
        }

        public TValue Value
        {
            get
            {
                TValue newValue = node.Value;
                if (cachedValue == null ||
                    (newValue == null && cachedValue != null) ||
                    (newValue != null && newValue.GetType() != cachedValue.GetType()))
                {
                    cachedValue = newValue;
                }

                return cachedValue;
            }
            set { node.Value = value; }
        }
    }
}