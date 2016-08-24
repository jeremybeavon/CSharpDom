using System;

namespace CSharpDom.CodeAnalysis
{
    internal static class NodeFactory
    {
        public static Node<TChildSyntax> CreateNode<TParentNode, TParentSyntax, TChildSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TChildSyntax> getChildSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TChildSyntax : class
        {
            Node<TChildSyntax> node = new Node<TChildSyntax>();
            node.SetParentNode(parent, getChildSyntax, createChildSyntax);
            return node;
        }
    }
}
