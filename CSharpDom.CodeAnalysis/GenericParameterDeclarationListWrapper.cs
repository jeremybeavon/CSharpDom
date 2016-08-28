using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class GenericParameterDeclarationListWrapper<TParentNode, TParentSyntax> :
        ImmutableListWrapper<
            TParentNode,
            TParentSyntax,
            GenericParameterDeclarationWithCodeAnalysis,
            GenericParameterDeclarationSyntax>
        where TParentNode : class
        where TParentSyntax : class
    {
        public GenericParameterDeclarationListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>> getTypeParameters,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses,
            Func<TParentNode, GenericParameterDeclarationWithCodeAnalysis> factory,
            Action<GenericParameterDeclarationWithCodeAnalysis, TParentNode> setParent)
            : base(
                  node,
                  ListFactory.CreateList(node, getTypeParameters, createTypeParameters, getConstraintClauses, createConstraintClauses),
                  factory,
                  setParent)
        {
        }
    }
}
