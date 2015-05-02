using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class WhileStatement : LinqExpressionMapping<LoopExpression, WhileStatementSyntax>
    {
        public WhileStatement(LoopExpression expression, WhileStatementSyntax syntax)
            : base(expression, syntax)
        {
        }

        public ILinqExpressionMapping Condition { get; internal set; }

        public ILinqExpressionMapping Statement { get; internal set; }
    }
}
