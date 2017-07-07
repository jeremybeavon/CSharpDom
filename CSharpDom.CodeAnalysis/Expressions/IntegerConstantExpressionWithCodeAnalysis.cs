using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class IntegerConstantExpressionWithCodeAnalysis :
        EditableIntegerConstantExpression,
        IInternalLiteralExpression
    {
        private readonly LiteralExpression<int> expression;

        internal IntegerConstantExpressionWithCodeAnalysis()
        {
            expression = new LiteralExpression<int>();
        }

        public override int Constant
        {
            get { return expression.Constant; }
            set { expression.Constant = value; }
        }

        public LiteralExpressionSyntax Syntax
        {
            get { return expression.Syntax; }
            set { expression.Syntax = value; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return expression.ExpressionSyntax; }
            set { expression.ExpressionSyntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => expression.Node;
    }
}
