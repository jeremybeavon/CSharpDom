﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class MemberListWrapperExtensions
    {
        public static StaticConstructorWithCodeAnalysis GetStaticConstructor<TParentNode, TParentSyntax>(
            this MemberListWrapper<TParentNode, TParentSyntax, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> list)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
        {
            return list.FirstOrDefault();
        }

        public static void SetStaticConstructor<TParentNode, TParentSyntax>(
            this MemberListWrapper<TParentNode, TParentSyntax, StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax> list,
            StaticConstructorWithCodeAnalysis constructor)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : TypeDeclarationSyntax
        {
            list.ReplaceFirst(constructor);
        }
    }
}
