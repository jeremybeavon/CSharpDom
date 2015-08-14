using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal interface IMemberModifier<TMember>
    {
        TMember Declaration { get; }

        TMember WithAttributeLists(TMember member, SyntaxList<AttributeListSyntax> attributes);

        TMember WithModifiers(TMember member, SyntaxTokenList modifiers);
    }
}
