using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IEnumMember : IHasName, IHasDeclaration<EnumMemberDeclarationSyntax>, IHasLocation
    {
    }
}
