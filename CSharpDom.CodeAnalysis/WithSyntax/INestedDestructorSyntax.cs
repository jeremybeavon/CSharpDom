using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedDestructorSyntax : 
        IDestructor<INestedClassDeclarationSyntax>,
        IHasDeclaration<DestructorDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
