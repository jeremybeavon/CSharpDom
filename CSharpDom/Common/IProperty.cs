using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IProperty : IHasName, IHasDeclaration<PropertyDeclarationSyntax>, IHasLocation
    {
        bool HasGet { get; }

        bool HasSet { get; }
    }
}
