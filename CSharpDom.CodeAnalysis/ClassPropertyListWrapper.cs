using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassPropertyListWrapper<TChildNode> :
        ClassMemberListWrapper<PropertyWithCodeAnalysis, TChildNode, PropertyDeclarationSyntax>
        where TChildNode : class, IHasSyntax<PropertyDeclarationSyntax>, IHasId
    {
        public ClassPropertyListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<PropertyDeclarationSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
