using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedClassDeclarationWithLinqExpressions : IClass, ITypeWithLinqExpressions,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasCompositeType<INestedClassWithLinqExpressions>,
        IHasSyntax<INestedClassDeclarationSyntax>,
        IHasSymbols<INestedClassDeclarationWithSymbols>,
        IHasReflection<INestedClassDeclarationWithReflection>
    {
    }
}
