using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassIndexerListWrapper<TChildNode> :
        ClassMemberListWrapper<IndexerWithCodeAnalysis, TChildNode, IndexerDeclarationSyntax>
        where TChildNode : class, IHasSyntax<IndexerDeclarationSyntax>, IHasId
    {
        public ClassIndexerListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<IndexerDeclarationSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
