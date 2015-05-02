using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class DoStatement : LinqExpressionMapping<LoopExpression, DoStatementSyntax>
    {
        public DoStatement(LoopExpression expression, DoStatementSyntax syntax)
            : base(expression, syntax)
        {
        }

        public ILinqExpressionMapping Condition { get; internal set; }

        public ILinqExpressionMapping Statement { get; internal set; }
    }
}
