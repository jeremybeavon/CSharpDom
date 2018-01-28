using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class LoadedDocumentMemberListWrapper<TChildNode, TChildSyntax> :
        ChildNodeList<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax, TChildNode, TChildSyntax>
        where TChildNode : class, IHasNode<TChildSyntax>
        where TChildSyntax : MemberDeclarationSyntax
    {
        public LoadedDocumentMemberListWrapper(
            Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> node,
            Func<TChildNode> factory,
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
            Func<TChildNode> factory,
            Func<TChildSyntax, bool> filter)
            : base(node, ListFactory.CreateFilteredList(node, getList, createList, filter), factory)
        {
        }
    }
}