using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassEventPropertyListWrapper<TChildNode> :
        ClassMemberListWrapper<EventPropertyWithCodeAnalysis, TChildNode, EventDeclarationSyntax>
        where TChildNode : class, IHasSyntax<EventDeclarationSyntax>, IHasId
    {
        public ClassEventPropertyListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<EventDeclarationSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
