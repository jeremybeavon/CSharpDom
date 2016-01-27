using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IEnumSyntax : 
        IEnum<INamespaceSyntax, IProjectSyntax, ISolutionSyntax, IEnumMemberSyntax>,
        IHasDeclaration<EnumDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
