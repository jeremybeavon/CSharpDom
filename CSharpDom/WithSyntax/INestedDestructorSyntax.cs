using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedDestructorSyntax : IDestructor, IHasDeclaringType<INestedClassDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
