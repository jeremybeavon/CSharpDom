using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal class BaseTypeNodeList<TParent, TParentSyntax> :
        ChildNodeList<TParent, TParentSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : TypeDeclarationSyntax
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList;

        public BaseTypeNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
            : base(
                  node,
                  new BaseTypeSyntaxList<TParent, TParentSyntax>(node, createList),
                  () => new InterfaceReferenceWithCodeAnalysis())
        {
            this.node = node;
            this.createList = createList;
        }

        public void ReplaceList(IEnumerable<InterfaceReferenceWithCodeAnalysis> newList)
        {
            TParentSyntax syntax = node.Syntax;
            SeparatedSyntaxList<BaseTypeSyntax> baseTypes =
                SyntaxFactory.SeparatedList(newList.Select(item => (BaseTypeSyntax)SyntaxFactory.SimpleBaseType(item.Syntax)));
            node.Syntax = createList(syntax, syntax.BaseList.WithTypes(baseTypes));
        }
    }
}
