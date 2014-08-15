using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface INestedClassWithSymbols : IClassWithSymbol, ITypeWithSymbols,
        IHasDeclarations<INestedClassDeclarationWithSymbols>,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasDestructor<INestedDestructorWithSymbols>,
        IHasSyntax<INestedClassSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
