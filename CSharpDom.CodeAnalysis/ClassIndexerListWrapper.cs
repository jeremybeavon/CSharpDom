using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassIndexerListWrapper<TClass, TChildNode> :
        ClassMemberListWrapper<TClass, TChildNode, IndexerDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<IndexerDeclarationSyntax>
    {
        public ClassIndexerListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<IndexerDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
