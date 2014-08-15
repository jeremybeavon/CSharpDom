using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface INestedStructSyntax : IStruct, ITypeSyntax, IHasDeclaringType<ITypeSyntax>,
        IHasDeclarations<INestedStructDeclarationSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
