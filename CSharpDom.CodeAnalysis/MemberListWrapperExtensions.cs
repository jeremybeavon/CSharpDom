using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class MemberListWrapperExtensions
    {
        public static TChildNode GetStaticConstructor<TParentNode, TParentSyntax, TChildNode>(
            this MemberListWrapper<TParentNode, TParentSyntax, TChildNode, ConstructorDeclarationSyntax> list)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
            where TChildNode : class, IHasNode<ConstructorDeclarationSyntax>
        {
            return list.FirstOrDefault();
        }

        public static void SetStaticConstructor<TParentNode, TParentSyntax, TChildNode>(
            this MemberListWrapper<TParentNode, TParentSyntax, TChildNode, ConstructorDeclarationSyntax> list,
            TChildNode constructor)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
            where TChildNode : class, IHasNode<ConstructorDeclarationSyntax>
        {
            list.ReplaceFirst(constructor);
        }
    }
}
