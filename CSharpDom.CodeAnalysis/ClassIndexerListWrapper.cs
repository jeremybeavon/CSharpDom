using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassIndexerListWrapper<TChildNode> :
        ClassMemberListWrapper<IndexerWithCodeAnalysis, TChildNode, IndexerDeclarationSyntax>
        where TChildNode : class, IHasNode<IndexerDeclarationSyntax>
    {
        public ClassIndexerListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<IndexerDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
