using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterDeclarationNodeList<TParent, TParentSyntax> :
        ChildNodeList<
            TParent,
            TParentSyntax,
            GenericParameterDeclarationWithCodeAnalysis,
            GenericParameterDeclarationSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters;
        private readonly Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses;

        public GenericParameterDeclarationNodeList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            : this(
                  node,
                  new TypeParameterSyntaxListConversions<TParentSyntax>(getTypeParameters, createTypeParameters),
                  getConstraintClauses,
                  createConstraintClauses)
        {
            this.node = node;
            this.createTypeParameters = createTypeParameters;
            this.createConstraintClauses = createConstraintClauses;
        }

        private GenericParameterDeclarationNodeList(
            Node<TParent, TParentSyntax> node,
            TypeParameterSyntaxListConversions<TParentSyntax> typeParameterConversions,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            : base(
                node,
                ListFactory.CreateChildSyntaxList(node, typeParameterConversions, getConstraintClauses, createConstraintClauses),
                () => new GenericParameterDeclarationWithCodeAnalysis())
        {
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
