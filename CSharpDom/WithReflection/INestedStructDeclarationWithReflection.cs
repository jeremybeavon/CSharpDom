using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public interface INestedStructDeclarationWithReflection : IStructWithSymbol, ITypeWithReflection,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasDeclaringType<ITypeWithReflection>,
        IHasCompositeType<INestedStructWithReflection>,
        IHasSyntax<INestedStructDeclarationSyntax>,
        IHasSymbols<INestedStructDeclarationWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
