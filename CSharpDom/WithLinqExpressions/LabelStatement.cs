using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class LabelStatement : LinqExpressionMapping<Expression, LabeledStatementSyntax>
    {
        public LabelStatement(LabelExpression label, ILinqExpressionMapping statement, LabeledStatementSyntax syntax)
            : base((new Expression[] { label }).Concat(statement.Expressions).ToArray(), syntax)
        {
            Label = label;
            Statement = statement;
        }

        public LabelExpression Label { get; private set; }

        public ILinqExpressionMapping Statement { get; private set; }
    }
}
