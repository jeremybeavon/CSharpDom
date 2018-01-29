using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal class InternalExpressionListWrapper<TParentNode, TParentSyntax> :
        SeparatedSyntaxNodeList<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        public InternalExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList)
            : base(node, getList, createList, ExpressionSyntaxExtensions.ToInternalExpression)
        {
        }
    }
}
