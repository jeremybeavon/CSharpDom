using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IProjectWithReflection : IProject<IDocumentWithReflection>, IHasAssembly,
        IHasSolution<ISolutionWithReflection>,
        IReflectionContainer,
        IHasSyntax<IProjectSyntax>,
        IHasSymbols<IProjectWithSymbols>
    {
        Task AcceptAsync(IReflectionVisitor visitor);
    }
}
