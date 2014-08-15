using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IInterfaceSyntax : IInterface, IBasicTypeSyntax,
        IHasDeclarations<IInterfaceDeclarationSyntax>,
        IHasNamespace<INamespaceSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
