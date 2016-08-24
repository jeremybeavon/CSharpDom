using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ValueNode<TNodeValue, TSyntax, TValue>
        where TSyntax : class
    {
        private readonly Node<TNodeValue, TSyntax> node;
        private readonly Func<TSyntax, TValue> getValue;
        private readonly Func<TSyntax, TValue, TSyntax> setValue;

        public ValueNode(
            Node<TNodeValue, TSyntax> node,
            Func<TSyntax, TValue> getValue,
            Func<TSyntax, TValue, TSyntax> setValue)
        {
            this.node = node;
            this.getValue = getValue;
            this.setValue = setValue;
        }

        public TValue Value
        {
            get { return getValue(node.Syntax); }
            set { node.Syntax = setValue(node.Syntax, value); }
        }
    }
}
