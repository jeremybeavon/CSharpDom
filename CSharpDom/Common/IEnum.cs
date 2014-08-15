using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IEnum : IHasName, IHasDeclaration<EnumDeclarationSyntax>, IHasLocation
    {
    }
}
