using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class MemberList<TParentNode, TParentSyntax> :
        MemberList<TParentNode, TParentSyntax, MemberDeclarationSyntax>,
        IMemberList
        where TParentSyntax : class
    {
        public MemberList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<MemberDeclarationSyntax>, TParentSyntax> createList)
            : base(node, (parentSyntax, childSyntax) => createList(parentSyntax, SyntaxFactory.List(childSyntax)))
        {
        }
        
        public void CombineList(params MemberListSyntax[] syntax)
        {
            CombineList(syntax.Cast<MemberListSyntax<MemberDeclarationSyntax>>());
        }
    }
}
