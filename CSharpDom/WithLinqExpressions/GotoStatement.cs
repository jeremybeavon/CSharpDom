using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class GotoStatement : LinqExpressionMapping<GotoExpression, GotoStatementSyntax>
    {
        public GotoStatement(GotoExpression expression, GotoStatementSyntax syntax)
            : base(expression, syntax)
        {
        }
    }
}
