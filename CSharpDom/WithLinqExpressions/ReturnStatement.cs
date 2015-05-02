using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ReturnStatement : LinqExpressionMapping<Expression, ReturnStatementSyntax>
    {
        public ReturnStatement(ILinqExpressionMapping expression, ReturnStatementSyntax syntax)
            : base(expression.Expressions, syntax)
        {
            ReturnExpression = expression;
        }

        public ILinqExpressionMapping ReturnExpression { get; private set; }
    }
}
