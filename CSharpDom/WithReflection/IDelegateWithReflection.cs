using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IDelegateWithReflection : IDelegateWithSymbol, IHasType,
        IHasNamespace<INamespaceWithReflection>,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        IHasSyntax<IDelegateSyntax>,
        IHasSymbols<IDelegateWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
