using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class AwaitExpressionWithCodeAnalysis :
        EditableAwaitExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<AwaitExpressionSyntax>,
        IInternalExpression
    {
        private readonly Guid internalId;
        private readonly ExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax> node;
        private readonly CachedExpressionNode<AwaitExpressionWithCodeAnalysis, AwaitExpressionSyntax> expression;

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public AwaitExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (AwaitExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        void IHasParent<IInternalExpression, ExpressionSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalExpression, ExpressionSyntax>> getCollection)
        {
            node.SetExpressionParentNode<TParentNode, TParentSyntax>(parent, getCollection);
        }

        void IHasParent<IInternalExpression, ExpressionSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, ExpressionSyntax> getChildSyntax,
            Func<TParentSyntax, ExpressionSyntax, TParentSyntax> createChildSyntax)
        {
            node.SetExpressionParentNode(parent, getChildSyntax, createChildSyntax);
        }
    }
}
