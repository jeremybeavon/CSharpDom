using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IDocumentSyntax : IDocument,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
