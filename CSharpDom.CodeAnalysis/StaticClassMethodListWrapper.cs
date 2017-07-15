using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StaticClassMethodListWrapper<TStaticClass, TChildNode> :
        StaticTypeMemberListWrapper<TStaticClass, TChildNode, MethodDeclarationSyntax>
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
        where TChildNode : class, IHasNode<MethodDeclarationSyntax>
    {
        public StaticClassMethodListWrapper(
            Node<TStaticClass, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<MethodDeclarationSyntax, bool> filter = null) :
            base(node, factory, filter)
        {
        }
    }
}
