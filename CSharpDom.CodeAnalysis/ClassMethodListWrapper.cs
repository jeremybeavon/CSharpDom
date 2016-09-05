using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class ClassMethodListWrapper<TChildNode> :
        ClassMemberListWrapper<MethodWithCodeAnalysis, TChildNode, MethodDeclarationSyntax>
        where TChildNode : class, IHasSyntax<MethodDeclarationSyntax>, IHasId
    {
        public ClassMethodListWrapper(
            Node<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax> node,
            Func<ClassTypeWithCodeAnalysis, TChildNode> factory,
            Action<TChildNode, ClassTypeWithCodeAnalysis> setParent,
            Func<MethodDeclarationSyntax, bool> filter = null)
            : base(node, factory, setParent, filter)
        {
        }
    }
}
