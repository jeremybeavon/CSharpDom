using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public interface INestedStructDeclarationSyntax : IStruct, ITypeSyntax, IHasLocation,
        IHasDeclaration<StructDeclarationSyntax>,
        IHasDeclaringType<ITypeSyntax>,
        IHasCompositeType<INestedStructSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
