using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IDelegate : IHasName, ICanBeGeneric, IHasDeclaration<DelegateDeclarationSyntax>, IHasLocation
    {
    }
}
