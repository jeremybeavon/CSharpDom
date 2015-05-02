using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface ILinqExpressionMapping<TExpression, TSyntax> : ILinqExpressionMapping
        where TExpression : Expression
        where TSyntax : SyntaxNode
    {
        new IReadOnlyCollection<TExpression> Expressions { get; }

        new TSyntax Syntax { get; }
    }
}
