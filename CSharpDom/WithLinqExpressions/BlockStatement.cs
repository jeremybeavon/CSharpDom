using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class BlockStatement : LinqExpressionMapping<BlockExpression, BlockSyntax>
    {
        internal BlockStatement(
            BlockExpression expression,
            BlockSyntax syntax,
            IReadOnlyList<ILinqExpressionMapping> statements)
            : base(expression, syntax)
        {
            Statements = statements;
        }

        public IReadOnlyList<ILinqExpressionMapping> Statements { get; private set; }
    }
}
