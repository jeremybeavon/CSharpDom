using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedEnumSyntax : 
        INestedEnum<ITypeSyntax, INestedEnumMemberSyntax>,
        IHasDeclaration<EnumDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
