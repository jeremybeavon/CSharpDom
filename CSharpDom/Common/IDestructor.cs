using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IDestructor : IHasDeclaration<DestructorDeclarationSyntax>, IHasLocation
    {
    }
}
