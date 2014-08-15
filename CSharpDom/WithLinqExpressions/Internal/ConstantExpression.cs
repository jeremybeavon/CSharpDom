using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LinqConstantExpression = System.Linq.Expressions.ConstantExpression;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class ConstantExpression : LinqExpressionMapping<LinqConstantExpression, LiteralExpressionSyntax>,
        IConstantExpression
    {
        public ConstantExpression(LinqConstantExpression expression, LiteralExpressionSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
