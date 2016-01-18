using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal interface IHasSyntaxNode
    {
        SyntaxNode SyntaxNode { get; }
    }
}
