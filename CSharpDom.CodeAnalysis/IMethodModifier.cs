using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMethodModifier<TMethod> : IMemberModifier<TMethod>
    {
        TMethod WithBody(TMethod method, BlockSyntax body);
    }
}
