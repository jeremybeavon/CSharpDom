using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IEvent : IHasName, IHasDeclaration<EventFieldDeclarationSyntax>, IHasLocation
    {
    }
}
