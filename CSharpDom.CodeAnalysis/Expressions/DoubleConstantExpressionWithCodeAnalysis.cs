using CSharpDom.BaseClasses.Editable.Expressions;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class DoubleConstantExpressionWithCodeAnalysis :
        EditableDoubleConstantExpression,
        IHasSyntax<LiteralExpressionSyntax>,
        IInternalExpression
    {
        private readonly LiteralExpression<double> expression;

        internal DoubleConstantExpressionWithCodeAnalysis()
        {
            expression = new LiteralExpression<double>();
        }

        public override double Constant
        {
            get { return expression.Constant; }
            set { expression.Constant = value; }
        }

        public LiteralExpressionSyntax Syntax
        {
            get { return expression.Syntax; }
            set { expression.Syntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return expression.Node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return expression.ExpressionSyntax; }
            set { expression.ExpressionSyntax = value; }
        }
    }
}
