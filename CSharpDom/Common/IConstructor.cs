using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IConstructor : IHasDeclaration<ConstructorDeclarationSyntax>, IHasLocation
    {
    }
}
