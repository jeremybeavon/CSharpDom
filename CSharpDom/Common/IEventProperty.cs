using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IEventProperty : IHasName, IHasDeclaration<EventDeclarationSyntax>, IHasLocation
    {
    }
}
