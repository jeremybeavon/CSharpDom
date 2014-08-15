using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IMethod : IHasName, ICanBeGeneric, IHasDeclaration<MethodDeclarationSyntax>, IHasLocation
    {
    }
}
