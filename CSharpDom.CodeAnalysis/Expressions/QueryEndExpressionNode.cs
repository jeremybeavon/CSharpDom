using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryEndExpressionNode<TValue, TSyntax> :
        AbstractChildNode<TValue, SelectOrGroupClauseSyntax, TSyntax>
        where TValue : IInternalQueryEndExpression
        where TSyntax : SelectOrGroupClauseSyntax
    {
        public QueryEndExpressionNode(TValue value)
            : base(value)
        {
        }
    }
}
