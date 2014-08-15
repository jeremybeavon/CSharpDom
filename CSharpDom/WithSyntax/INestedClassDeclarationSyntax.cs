using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface INestedClassDeclarationSyntax : IClass, ITypeSyntax,
        IHasDeclaration<ClassDeclarationSyntax>,
        IHasDeclaringType<ITypeSyntax>,
        IHasCompositeType<INestedClassSyntax>,
        IHasDestructor<INestedDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
