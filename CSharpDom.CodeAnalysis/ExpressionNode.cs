using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ExpressionNode<TValue, TSyntax> : AbstractChildNode<TValue, ExpressionSyntax, TSyntax>
        where TValue : IInternalExpression
        where TSyntax : ExpressionSyntax
    {
        public ExpressionNode(TValue value)
            : base(value)
        {
        }
    }
}
