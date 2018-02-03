using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedExpressionNode<TParent, TParentSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParent, TParentSyntax, IInternalExpression, ExpressionSyntax> childNode;

        public CachedExpressionNode(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, ExpressionSyntax> getSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createSyntax)
        {
            childNode = new CachedChildNode<TParent, TParentSyntax, IInternalExpression, ExpressionSyntax>(
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
