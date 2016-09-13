using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventListWrapper<TChildNode> :
        ClassMemberListWrapper<EventWithCodeAnalysis, TChildNode, EventFieldDeclarationSyntax>
        where TChildNode : class, IHasNode<EventFieldDeclarationSyntax>
    {
        public ClassEventListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<TChildNode> factory,
            Func<EventFieldDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
