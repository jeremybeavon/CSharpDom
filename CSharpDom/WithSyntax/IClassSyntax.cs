using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IClassSyntax : IClass,
        IHasDeclarations<IClassDeclarationSyntax>,
        IHasNamespace<INamespaceSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax,
        IHasDestructor<IDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
