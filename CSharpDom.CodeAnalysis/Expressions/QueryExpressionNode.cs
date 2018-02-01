using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryExpressionNode<TValue, TSyntax> : AbstractChildNode<TValue, QueryClauseSyntax, TSyntax>
        where TValue : IInternalQueryExpression
        where TSyntax : QueryClauseSyntax
    {
        public QueryExpressionNode(TValue value)
            : base(value)
        {
        }
    }
}
