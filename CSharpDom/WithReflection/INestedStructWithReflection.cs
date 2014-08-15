using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface INestedStructWithReflection : IStructWithSymbol, ITypeWithReflection,
        IHasDeclaringType<ITypeWithReflection>,
        IHasDeclarations<INestedStructDeclarationWithReflection>,
        IHasSyntax<INestedStructSyntax>,
        IHasSymbols<INestedStructWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
