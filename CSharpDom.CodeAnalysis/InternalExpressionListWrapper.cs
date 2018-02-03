using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal class InternalExpressionListWrapper<TParent, TParentSyntax> :
        SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalExpression, ExpressionSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        public InternalExpressionListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList)
            : base(node, getList, createList, ExpressionSyntaxExtensions.ToInternalExpression)
        {
        }
    }
}
