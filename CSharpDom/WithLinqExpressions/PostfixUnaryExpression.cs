using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqExpression = System.Linq.Expressions.Expression;
using LinqUnaryExpression = System.Linq.Expressions.UnaryExpression;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class PostfixUnaryExpression : LinqExpressionMapping<LinqUnaryExpression, PostfixUnaryExpressionSyntax>
    {
        private static readonly IReadOnlyDictionary<SyntaxKind, UnaryExpressionBuilder> ExpressionBuilders =
            new UnaryExpressionBuilderList()
        {
            { SyntaxKind.MinusMinusToken, LinqExpression.PostDecrementAssign, UnaryExpressionType.PostfixDecrement },
            { SyntaxKind.PlusPlusToken, LinqExpression.PostIncrementAssign, UnaryExpressionType.PostfixIncrement }
        };

        internal PostfixUnaryExpression(ILinqExpressionMapping operand, PostfixUnaryExpressionSyntax syntax)
            : this(operand, ExpressionBuilders[syntax.OperatorToken.CSharpKind()], syntax)
        {
        }

        private PostfixUnaryExpression(
            ILinqExpressionMapping operand,
            UnaryExpressionBuilder builder,
            PostfixUnaryExpressionSyntax syntax)
            : base(builder.LinqExpressionBuilder(operand.Expression), syntax)
        {
            Operand = operand;
            ExpressionType = builder.ExpressionType;
        }

        public ILinqExpressionMapping Operand { get; private set; }

        public UnaryExpressionType ExpressionType { get; private set; }
    }
}
