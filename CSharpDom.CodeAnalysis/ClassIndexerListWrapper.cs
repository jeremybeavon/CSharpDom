using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassIndexerListWrapper<TClass, TChild> :
        ClassMemberListWrapper<TClass, TChild, IndexerDeclarationSyntax>
        where TClass : class, IHasNode<ClassDeclarationSyntax>
        where TChild : class, IHasNode<IndexerDeclarationSyntax>
    {
        public ClassIndexerListWrapper(
            Node<TClass, ClassDeclarationSyntax> node,
            Func<TChild> factory,
            Func<IndexerDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
