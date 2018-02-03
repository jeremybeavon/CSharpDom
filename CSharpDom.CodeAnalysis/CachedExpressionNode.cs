using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedExpressionNode<TParentNode, TParentSyntax>
        where TParentNode : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> childNode;

        public CachedExpressionNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, ExpressionSyntax> getSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createSyntax)
        {
            childNode = new CachedChildNode<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>(
                node,
                ExpressionSyntaxExtensions.ToInternalExpression,
                getSyntax,
                createSyntax);
        }
        
        public IExpressionWithCodeAnalysis Value
        {
            get { return childNode.Value; }
            set { childNode.Value = (IInternalExpression)value; }
        }
    }
}
