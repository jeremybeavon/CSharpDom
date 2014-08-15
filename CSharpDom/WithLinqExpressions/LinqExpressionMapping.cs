using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public abstract class LinqExpressionMapping<TExpression, TSyntax> : ILinqExpressionMapping
        where TExpression : Expression
    {
        protected LinqExpressionMapping(TExpression expression, TSyntax syntax)
        {
            Expression = expression;
            Syntax = syntax;
        }

        public TExpression Expression { get; private set; }

        public TSyntax Syntax { get; private set; }

        Expression ILinqExpressionMapping.Expression
        {
            get { return Expression; }
        }

        SyntaxNode ILinqExpressionMapping.Syntax
        {
            get { return Syntax; }
        }
    }
}
