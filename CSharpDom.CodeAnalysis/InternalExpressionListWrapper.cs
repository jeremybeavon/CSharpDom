using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal class InternalExpressionListWrapper<TParentNode, TParentSyntax>
        : SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        public InternalExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList,
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
            : this(
                  node,
                  getList,
                  createList,
                  InternalListWrapperBuilder.Create<TParentNode, TParentSyntax>(getCollection))
        {
        }

        private InternalExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<ExpressionSyntax>, TParentSyntax> createList,
            InternalListWrapperBuilder<TParentNode, TParentSyntax, IInternalExpression, ExpressionSyntax> builder)
            : base(node, getList, createList, builder.CreateItem, builder.SetParent)
        {
        }
    }
}
