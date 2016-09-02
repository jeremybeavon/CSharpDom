using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
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
            GenericParameterDeclarationSyntax>,
        IGenericParameterCollection
        where TParentNode : class
        where TParentSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters;
        private readonly Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses;

        public GenericParameterDeclarationListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters,
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
            this.node = node;
            this.createTypeParameters = createTypeParameters;
            this.createConstraintClauses = createConstraintClauses;
        }

        public void ReplaceList(IEnumerable<GenericParameterDeclarationWithCodeAnalysis> newList)
        {
            TParentSyntax syntax = node.Syntax;
            syntax = createTypeParameters(
                syntax,
                SyntaxFactory.TypeParameterList(SyntaxFactory.SeparatedList(newList.Select(item => item.Syntax.TypeParameter))));
            IEnumerable<TypeParameterConstraintClauseSyntax> constraintClauses =
                newList.Select(node => node.Syntax.ConstraintClause).Where(clause => clause != null);
            node.Syntax = createConstraintClauses(
                syntax,
                SyntaxFactory.List(newList.Select(item => item.Syntax.ConstraintClause).Where(clause => clause != null)));
        }
    }
}
