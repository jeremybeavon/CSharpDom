using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedExpressionNode<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> node;

        public CachedExpressionNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, ExpressionSyntax> getSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createSyntax)
            : this(node, createSyntax, CachedNodeBuilder.Create<TParentNode, TParentSyntax>(getSyntax, createSyntax))
        {
        }

        private CachedExpressionNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createSyntax,
            CachedNodeBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> builder)
        {
            this.node = new CachedChildNode<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>(
                node,
                createSyntax,
                builder.GetValue,
                builder.SetParent);
        }

        public IExpressionWithCodeAnalysis Value
        {
            get { return node.Value; }
            set { node.Value = (IInternalExpression)value; }
        }
    }
}
