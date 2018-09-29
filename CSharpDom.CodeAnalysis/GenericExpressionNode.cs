using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class GenericExpressionNode<TValue, TSyntax> : AbstractChildNode<TValue, ExpressionSyntax, TSyntax>
        where TValue : IInternalGenericExpression
        where TSyntax : ExpressionSyntax
    {
        public GenericExpressionNode(TValue value)
            : base(value)
        {
        }
    }
}
