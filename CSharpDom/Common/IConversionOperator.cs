using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IConversionOperator : IHasDeclaration<ConversionOperatorDeclarationSyntax>, IHasLocation
    {
    }
}
