using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class GenericParameterListWrapper<TParentNode> :
        SeparatedSyntaxListWrapper<TParentNode, NameSyntax, GenericParameterWithCodeAnalysis, TypeSyntax>
        where TParentNode : class, IHasSyntax<NameSyntax>
    {
        public GenericParameterListWrapper(
            Node<TParentNode, NameSyntax> node,
            Func<NameSyntax, SeparatedSyntaxList<TypeSyntax>> getList,
            Func<NameSyntax, SeparatedSyntaxList<TypeSyntax>, NameSyntax> createList)
            : base(
                  node,
                  getList,
                  createList,
                  () => new GenericParameterWithCodeAnalysis(null))
        {
        }
    }
}
