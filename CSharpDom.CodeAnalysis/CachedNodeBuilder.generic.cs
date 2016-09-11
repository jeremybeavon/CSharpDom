using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class CachedNodeBuilder<TParentNode, TParentSyntax, TChildNode, TChildSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
        where TChildNode : IHasParent<TChildNode, TChildSyntax>
    {
        private readonly Func<TChildSyntax, TChildNode> createNode;
        private readonly Func<TParentSyntax, TChildSyntax> getSyntax;
        private readonly Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax;

        public CachedNodeBuilder(
            Func<TChildSyntax, TChildNode> createNode,
            Func<TParentSyntax, TChildSyntax> getSyntax,
            Func<TParentSyntax, TChildSyntax, TParentSyntax> createSyntax)
        {
            this.createNode = createNode;
            this.getSyntax = getSyntax;
            this.createSyntax = createSyntax;
        }

        public TChildNode GetValue(TParentNode parent, TChildSyntax syntax)
        {
            TChildNode node = createNode(syntax);
            SetParent(node, parent);
            return node;
        }

        public void SetParent(TChildNode child, TParentNode parent)
        {
            child.SetParentNode(parent, getSyntax, createSyntax);
        }
    }
}
