using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class OutExpressionWithCodeAnalysis :
        EditableOutExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly Node<OutExpressionWithCodeAnalysis, ArgumentSyntax> node;
        private readonly CachedExpressionNode<OutExpressionWithCodeAnalysis, ArgumentSyntax> expression;

        public OutExpressionWithCodeAnalysis(IExpressionWithCodeAnalysis expression)
            : this()
        {
            Syntax = SyntaxFactory.Argument(null, SyntaxFactory.Token(SyntaxKind.OutKeyword), expression.Syntax);
        }

        internal OutExpressionWithCodeAnalysis()
        {
            node = new Node<OutExpressionWithCodeAnalysis, ArgumentSyntax>(this);
            expression = new CachedExpressionNode<OutExpressionWithCodeAnalysis, ArgumentSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Expression
        {
            get { return expression.Value; }
            set { expression.Value = value; }
        }

        public ArgumentSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        IExpressionWithCodeAnalysis IInternalArgument.Expression
        {
            get { return Expression; }
        }

        INode<ArgumentSyntax> IHasNode<ArgumentSyntax>.Node
        {
            get { return node; }
        }
    }
}
