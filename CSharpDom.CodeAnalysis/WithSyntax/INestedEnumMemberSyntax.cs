using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface INestedEnumMemberSyntax :
        IEnumMember<INestedEnumSyntax>,
        IHasDeclaration<EnumMemberDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
