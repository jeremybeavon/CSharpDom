using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IConversionOperatorSyntax :
        IConversionOperator<ITypeSyntax>,
        IHasDeclaration<ConversionOperatorDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
