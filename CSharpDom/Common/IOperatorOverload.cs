using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IOperatorOverload : IHasDeclaration<OperatorDeclarationSyntax>, IHasLocation
    {
    }
}
