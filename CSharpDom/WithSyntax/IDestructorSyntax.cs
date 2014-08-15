using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IDestructorSyntax : IDestructor, IHasDeclaringType<IClassDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
