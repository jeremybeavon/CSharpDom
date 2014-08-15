using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    internal sealed class MemberImplementation<TSyntax> : LinqExpressionMapping<LambdaExpression, TSyntax>,
        IImplementation
        where TSyntax : SyntaxNode
    {
        public MemberImplementation(LambdaExpression expression, TSyntax syntax, BlockStatement body)
            : base(expression, syntax)
        {
            Body = body;
        }

        public BlockStatement Body { get; private set; }
    }
}
