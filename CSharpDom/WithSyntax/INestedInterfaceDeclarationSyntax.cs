using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface INestedInterfaceDeclarationSyntax : IInterface, IBasicTypeSyntax,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasDeclaringType<ITypeSyntax>,
        IHasCompositeType<INestedInterfaceSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
