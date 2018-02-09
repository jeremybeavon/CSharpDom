using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class LoadedDocumentMemberListWrapper<TChild, TChildSyntax> :
        ChildNodeList<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax, TChild, TChildSyntax>
        where TChild : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public LoadedDocumentMemberListWrapper(
            Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> node,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter = null)
            : this(
                  node,
                  syntax => syntax.Members,
                  (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax),
                  factory,
                  filter)
        {
        }

        private LoadedDocumentMemberListWrapper(
            Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> node,
            Func<CompilationUnitSyntax, SyntaxList<MemberDeclarationSyntax>> getList,
            Func<CompilationUnitSyntax, SyntaxList<MemberDeclarationSyntax>, CompilationUnitSyntax> createList,
            Func<TChild> factory,
            Func<TChildSyntax, bool> filter)
            : base(node, ListFactory.CreateFilteredSyntaxList(node, getList, createList, filter), factory)
        {
        }
    }
}