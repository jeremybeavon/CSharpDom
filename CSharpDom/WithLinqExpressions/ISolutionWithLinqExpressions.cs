using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface ISolutionWithLinqExpressions : ISolution<IProjectWithLinqExpressions>, IHasSyntax<ISolutionSyntax>,
        IHasSymbols<ISolutionWithSymbols>,
        IHasReflection<ISolutionWithReflection>
    {
        Task AcceptAsync(ILinqExpressionsVisitor visitor);
    }
}
