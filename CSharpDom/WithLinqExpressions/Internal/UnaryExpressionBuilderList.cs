using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqUnaryExpression = System.Linq.Expressions.UnaryExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class UnaryExpressionBuilderList : Dictionary<SyntaxKind, UnaryExpressionBuilder>
    {
        public void Add(
            SyntaxKind syntaxKind,
            Func<Expression, LinqUnaryExpression> linqExpressionBuilder,
            UnaryExpressionType expressionType)
        {
            Add(syntaxKind, new UnaryExpressionBuilder(linqExpressionBuilder, expressionType));
        }
    }
}
