using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal static class MemberListWrapperExtensions
    {
        public static StaticConstructorWithCodeAnalysis GetStaticConstructor<TParentNode, TParentSyntax>(
            this MemberListWrapper<TParentNode, TParentSyntax, EmptySimpleMember, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> list)
            where TParentNode : class
            where TParentSyntax : TypeDeclarationSyntax
        {
            return list.Count == 0 ? null : list[0];
        }

        public static void SetStaticConstructor<TParentNode, TParentSyntax>(
            this MemberListWrapper<TParentNode, TParentSyntax, EmptySimpleMember, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> list,
            StaticConstructorWithCodeAnalysis constructor)
            where TParentNode : class
            where TParentSyntax : TypeDeclarationSyntax
        {
            if (list.Count == 0)
            {
                if (constructor != null)
                {
                    list.Add(constructor);
                }
            }
            else if (constructor == null)
            {
                list.RemoveAt(0);
            }
            else
            {
                list[0] = constructor;
            }
        }
    }
}
