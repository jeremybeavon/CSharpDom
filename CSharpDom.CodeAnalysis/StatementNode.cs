using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementNode<TValue, TSyntax> : AbstractChildNode<TValue, StatementSyntax, TSyntax>
        where TValue : IInternalStatement
        where TSyntax : StatementSyntax
    {
        public StatementNode(TValue value)
            : base(value)
        {
        }
    }
}
