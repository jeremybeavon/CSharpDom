using Microsoft.CodeAnalysis;

namespace CSharpDom
{
    internal interface IHasSyntaxNode
    {
        SyntaxNode SyntaxNode { get; }
    }
}
