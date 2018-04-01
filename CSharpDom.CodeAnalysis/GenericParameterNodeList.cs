using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterNodeList<TParent, TParentSyntax> :
        SeparatedSyntaxNodeList<TParent, TParentSyntax, IInternalTypeReferenceWithCodeAnalysis, TypeSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        public GenericParameterNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, NameSyntax> getSyntax,
            Func<TParentSyntax, NameSyntax, TParentSyntax> setSyntax)
            : base(
                  node,
                  syntax => getSyntax(syntax)?.ToGenericParameters() ?? SyntaxFactory.SeparatedList<TypeSyntax>(),
                  (parentSyntax, childSyntax) => setSyntax(parentSyntax, getSyntax(parentSyntax).WithGenericParameters(childSyntax)),
                  UnspecifiedTypeReferenceWithCodeAnalysis.GetTypeReference)
        {
        }
    }
}
