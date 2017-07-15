using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMemberList<TClass> : MemberList<TClass, ClassDeclarationSyntax>
    {
        public ClassMemberList(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<ClassDeclarationSyntax, SyntaxList<MemberDeclarationSyntax>, ClassDeclarationSyntax> createList)
            : base(node, createList)
        {
        }
    }
}
