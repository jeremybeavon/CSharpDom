using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqBinaryExpression = System.Linq.Expressions.BinaryExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class BinaryExpressionBuilderList : Dictionary<SyntaxKind, BinaryExpressionBuilder>
    {
        public void Add(
            SyntaxKind syntaxKind,
            Func<Expression, Expression, LinqBinaryExpression> linqExpressionBuilder,
            BinaryExpressionType expressionType)
        {
            Add(syntaxKind, new BinaryExpressionBuilder(linqExpressionBuilder, expressionType));
        }
    }
}
