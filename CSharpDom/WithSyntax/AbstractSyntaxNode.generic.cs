using System;

namespace CSharpDom.WithSyntax
{
    public abstract class AbstractSyntaxNode<T> : AbstractSyntaxNode, IWrapper<T>
        where T : class
    {
        private readonly T node;

        protected AbstractSyntaxNode(T node)
        {
            this.node = node;
        }

        T IWrapper<T>.ObjectToWrap
        {
            get { return node; }
        }

        public sealed override string ToString()
        {
            return node.ToString();
        }

        public sealed override int GetHashCode()
        {
            return node.GetHashCode();
        }

        public sealed override bool Equals(object obj)
        {
            IWrapper<T> wrapper = obj as IWrapper<T>;
            T otherNode = wrapper == null ? obj as T : wrapper.ObjectToWrap;
            return node != null && Equals(node, otherNode);
        }
    }
}
