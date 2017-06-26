using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StaticClassMethodListWrapper<TChildNode> :
        StaticTypeMemberListWrapper<TChildNode, MethodDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public StaticClassMethodListWrapper(
            Node<StaticTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
