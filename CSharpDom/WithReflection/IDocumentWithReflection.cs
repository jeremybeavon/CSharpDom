using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IDocumentWithReflection : IDocument,
        IHasProject<IProjectWithReflection>,
        IHasSolution<ISolutionWithReflection>,
        IHasSyntax<IDocumentSyntax>,
        IHasSymbols<IDocumentWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
