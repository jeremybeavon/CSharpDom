using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedStatementNode<TParentNode, TParentSyntax> :
        CachedChildNode<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        public CachedStatementNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
            : this(node, createSyntax, new CachedStatementNodeBuilder<TParentNode, TParentSyntax>(getSyntax, createSyntax))
        {
        }

        private CachedStatementNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax,
            CachedStatementNodeBuilder<TParentNode, TParentSyntax> builder)
            : base(node, createSyntax, builder.GetValue, builder.SetParent)
        {
        }
    }
}
