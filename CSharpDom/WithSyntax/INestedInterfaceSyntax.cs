using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedInterfaceSyntax : IInterface, IBasicTypeSyntax, IHasDeclaringType<ITypeSyntax>,
        IHasDeclarations<INestedInterfaceDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
