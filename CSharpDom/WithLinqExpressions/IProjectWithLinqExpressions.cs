using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IProjectWithLinqExpressions : IProject<IDocumentWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        ILinqExpressionContainer,
        IHasSyntax<IProjectSyntax>,
        IHasSymbols<IProjectWithSymbols>,
        IHasReflection<IProjectWithReflection>
    {
        Task AcceptAsync(ILinqExpressionsVisitor visitor);
    }
}
