using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IField : IHasName, IHasDeclaration<FieldDeclarationSyntax>, IHasLocation
    {
    }
}
