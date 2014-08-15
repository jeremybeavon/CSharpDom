using CSharpDom.Common;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithSymbols
{
    public interface IClassWithSymbols : IClassWithSymbol,
        IHasDeclarations<IClassDeclarationWithSymbols>,
        IHasNamespace<INamespaceWithSymbols>,
        IHasProject<IProjectWithSymbols>,
        IHasSolution<ISolutionWithSymbols>,
        ITypeWithSymbols,
        IHasDestructor<IDestructorWithSymbols>,
        IHasSyntax<IClassSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
