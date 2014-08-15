using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IStructSyntax : IStruct,
        IHasDeclarations<IStructDeclarationSyntax>,
        IHasNamespace<INamespaceSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
