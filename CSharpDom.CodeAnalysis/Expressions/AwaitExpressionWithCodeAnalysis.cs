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
        
        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (AwaitExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }
    }
}
