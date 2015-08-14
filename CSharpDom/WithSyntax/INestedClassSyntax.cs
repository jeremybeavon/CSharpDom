using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedClassSyntax : IClass, ITypeSyntax, IHasDeclaringType<ITypeSyntax>,
        IHasDeclarations<INestedClassDeclarationSyntax>,
        IHasDestructor<INestedDestructorSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
