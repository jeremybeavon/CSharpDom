using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqExpression = System.Linq.Expressions.Expression;
using LinqUnaryExpression = System.Linq.Expressions.UnaryExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class UnaryExpression : LinqExpressionMapping<LinqUnaryExpression, PrefixUnaryExpressionSyntax>,
        IUnaryExpression
    {
        private static readonly IReadOnlyDictionary<SyntaxKind, UnaryExpressionBuilder> ExpressionBuilders =
            new UnaryExpressionBuilderList()
        {
            { SyntaxKind.TildeToken, LinqExpression.Not, UnaryExpressionType.BitwiseNot },
            { SyntaxKind.ExclamationToken, LinqExpression.Not, UnaryExpressionType.LogicalNot },
            { SyntaxKind.PlusPlusToken, LinqExpression.PreDecrementAssign, UnaryExpressionType.PrefixDecrement },
            { SyntaxKind.MinusMinusToken, LinqExpression.PreIncrementAssign, UnaryExpressionType.PrefixIncrement },
            { SyntaxKind.MinusToken, LinqExpression.Negate, UnaryExpressionType.Negate },
            { SyntaxKind.PlusToken, LinqExpression.UnaryPlus, UnaryExpressionType.UnaryPlus }
        };

        public UnaryExpression(ILinqExpressionMapping operand, PrefixUnaryExpressionSyntax syntax)
            : this(operand, ExpressionBuilders[syntax.OperatorToken.Kind()], syntax)
        {
        }

        private UnaryExpression(
            ILinqExpressionMapping operand,
            UnaryExpressionBuilder builder,
            PrefixUnaryExpressionSyntax syntax)
            : base(builder.LinqExpressionBuilder(operand.Expressions.Single()), syntax)
        {
            Operand = operand;
            ExpressionType = builder.ExpressionType;
        }

        public ILinqExpressionMapping Operand { get; private set; }

        public UnaryExpressionType ExpressionType { get; private set; }
    }
}
