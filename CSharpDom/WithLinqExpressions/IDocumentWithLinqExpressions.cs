using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IDocumentWithLinqExpressions : IDocument,
        IHasProject<IProjectWithLinqExpressions>,
        IHasSolution<ISolutionWithLinqExpressions>,
        IHasSyntax<IDocumentSyntax>,
        IHasSymbols<IDocumentWithSymbols>,
        IHasReflection<IDocumentWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
