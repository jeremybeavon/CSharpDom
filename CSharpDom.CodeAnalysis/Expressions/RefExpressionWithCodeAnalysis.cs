using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class RefExpressionWithCodeAnalysis :
        EditableOutExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ArgumentSyntax>,
        IInternalArgument
    {
        private readonly Node<RefExpressionWithCodeAnalysis, ArgumentSyntax> node;
        private readonly CachedExpressionNode<RefExpressionWithCodeAnalysis, ArgumentSyntax> expression;

        public RefExpressionWithCodeAnalysis()
        {
            node = new Node<RefExpressionWithCodeAnalysis, ArgumentSyntax>(this);
            expression = new CachedExpressionNode<RefExpressionWithCodeAnalysis, ArgumentSyntax>(
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
