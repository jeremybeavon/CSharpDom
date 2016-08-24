using System;

namespace CSharpDom.CodeAnalysis
{
    internal static class NodeFactory
    {
        public static Node<TChildNode, TChildSyntax> CreateNode<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(
            TChildNode child,
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TChildSyntax : class
        {
            Node<TChildNode, TChildSyntax> node = new Node<TChildNode, TChildSyntax>(child);
            node.SetParentNode(parent, getChildSyntax, createChildSyntax);
            return node;
        }
    }
}
