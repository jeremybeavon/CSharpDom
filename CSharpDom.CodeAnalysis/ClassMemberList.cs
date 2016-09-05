﻿using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMemberList : MemberList<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>
    {
        public ClassMemberList(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>, ClassDeclarationSyntax> createList)
            : base(node, createList)
        {
        }
    }
}
