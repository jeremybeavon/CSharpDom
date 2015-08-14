using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface IClassDeclarationSyntax : IClass, IHasLocation,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasCompositeType<IClassSyntax>,
        IHasDocument<IDocumentSyntax>,
        IHasProject<IProjectSyntax>,
        IHasSolution<ISolutionSyntax>,
        ITypeSyntax,
        IHasDestructor<IDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
