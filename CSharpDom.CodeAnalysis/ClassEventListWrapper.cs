using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventListWrapper<TChildNode> :
        ClassMemberListWrapper<EventWithCodeAnalysis, TChildNode, EventFieldDeclarationSyntax>
        where TChildNode : class, IHasSyntax<EventFieldDeclarationSyntax>, IHasId
    {
        public ClassEventListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<EventFieldDeclarationSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
