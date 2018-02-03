using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class MemberListWrapperExtensions
    {
        public static TChild GetStaticConstructor<TParent, TParentSyntax, TChild>(
            this MemberListWrapper<TParent, TParentSyntax, TChild, ConstructorDeclarationSyntax> list)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
            where TChild : class, IHasNode<ConstructorDeclarationSyntax>
        {
            return list.FirstOrDefault();
        }

        public static void SetStaticConstructor<TParent, TParentSyntax, TChild>(
            this MemberListWrapper<TParent, TParentSyntax, TChild, ConstructorDeclarationSyntax> list,
            TChild constructor)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
            where TChild : class, IHasNode<ConstructorDeclarationSyntax>
        {
            list.ReplaceFirst(constructor);
        }
    }
}
