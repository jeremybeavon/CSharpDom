using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedStatementNode<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> node;

        public CachedStatementNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
            : this(node, createSyntax, CachedNodeBuilder.Create<TParentNode, TParentSyntax>(getSyntax, createSyntax))
        {
        }

        private CachedStatementNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax,
            CachedNodeBuilder<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> builder)
        {
            this.node = new CachedChildNode<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>(
                node,
                createSyntax,
                builder.GetValue,
                builder.SetParent);
        }

        public IStatementWithCodeAnalysis Value
        {
            get { return node.Value; }
            set { node.Value = (IInternalStatement)value; }
        }
    }
}
