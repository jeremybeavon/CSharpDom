using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface ISolutionWithReflection : ISolution<IProjectWithReflection>, IHasSyntax<ISolutionSyntax>,
        IHasSymbols<ISolutionWithSymbols>
    {
        Task AcceptAsync(IReflectionVisitor visitor);
    }
}
