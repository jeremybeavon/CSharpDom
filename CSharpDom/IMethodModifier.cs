using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal interface IMethodModifier<TMethod> : IMemberModifier<TMethod>
    {
        TMethod WithBody(TMethod method, BlockSyntax body);
    }
}
