using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface INestedClassDeclarationWithReflection : IClassWithSymbol, ITypeWithReflection,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasDeclaringType<ITypeWithReflection>,
        IHasCompositeType<INestedClassWithReflection>,
        IHasSyntax<INestedClassDeclarationSyntax>,
        IHasSymbols<INestedClassDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
