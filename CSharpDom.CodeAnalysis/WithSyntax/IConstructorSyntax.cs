using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IConstructorSyntax : IConstructor<ITypeSyntax>, IHasDeclaration<ConstructorDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
