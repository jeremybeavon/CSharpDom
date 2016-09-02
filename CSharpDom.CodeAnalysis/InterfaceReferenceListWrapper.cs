//using System;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp.Syntax;

//namespace CSharpDom.CodeAnalysis
//{
//    internal class InterfaceReferenceListWrapper<TParentNode, TParentSyntax> :
//        ImmutableListWrapper<TParentNode, TParentSyntax, InterfaceReferenceWithCodeAnalysis, NameSyntax>
//        where TParentNode : class
//        where TParentSyntax : class
//    {
//        public InterfaceReferenceListWrapper(
//            Node<TParentNode, TParentSyntax> node,
//            Func<TParentSyntax, BaseListSyntax> getList,
//            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList,
//            Func<TParentNode, InterfaceReferenceWithCodeAnalysis> factory,
//            Action<InterfaceReferenceWithCodeAnalysis, TParentNode> setParent)
//            : base(node, syntax => getList(syntax).Types, createList, factory, setParent)
//        {
//        }
//    }
//}
