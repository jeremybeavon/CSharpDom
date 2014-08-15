using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedStructDeclarationWithLinqExpressions : IStruct, ITypeWithLinqExpressions,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasCompositeType<INestedStructWithLinqExpressions>,
        IHasSyntax<INestedStructDeclarationSyntax>,
        IHasSymbols<INestedStructDeclarationWithSymbols>,
        IHasReflection<INestedStructDeclarationWithReflection>
    {
    }
}
