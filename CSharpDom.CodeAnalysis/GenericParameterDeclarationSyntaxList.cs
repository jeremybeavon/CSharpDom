﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterDeclarationSyntaxList<TParent, TParentSyntax> :
        IChildSyntaxList<TParentSyntax, GenericParameterDeclarationSyntax>
        where TParentSyntax : class
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly IList<TypeParameterSyntax> typeParameters;
        private readonly IList<TypeParameterConstraintClauseSyntax> constraintClauses;

        public GenericParameterDeclarationSyntaxList(
            Node<TParent, TParentSyntax> node,
            TypeParameterSyntaxListConversions<TParentSyntax> typeParameterConversions,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
        {
            this.node = node;
            typeParameters = ListFactory.CreateChildSyntaxList(node, typeParameterConversions);
            constraintClauses = ListFactory.CreateChildSyntaxList(node, getConstraintClauses, createConstraintClauses);
        }

        public int Count
        {
            get { return typeParameters.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public GenericParameterDeclarationSyntax this[int index]
        {
            get { return GetSyntax(typeParameters[index]); }
            set
            {
                if (value.ConstraintClause != null)
                {
                    int? constraintClauseIndex = GetConstraintClauseIndex(typeParameters[index]);
                    if (constraintClauseIndex.HasValue)
                    {
                        constraintClauses[constraintClauseIndex.Value] = value.ConstraintClause;
                    }
                    else
                    {
                        constraintClauses.Add(value.ConstraintClause);
                    }
                }

                typeParameters[index] = value.TypeParameter;
            }
        }

        public int IndexOf(GenericParameterDeclarationSyntax item)
        {
            return typeParameters.IndexOf(item.TypeParameter);
        }

        public void Insert(int index, GenericParameterDeclarationSyntax item)
        {
            typeParameters.Insert(index, item.TypeParameter);
            constraintClauses.Insert(Math.Min(index, constraintClauses.Count), item.ConstraintClause);
        }

        public void RemoveAt(int index)
        {
            TypeParameterConstraintClauseSyntax constraintClause = GetConstraintClause(typeParameters[index]);
            if (constraintClause != null)
            {
                constraintClauses.Remove(constraintClause);
            }

            typeParameters.RemoveAt(index);
        }

        public void Add(GenericParameterDeclarationSyntax item)
        {
            typeParameters.Add(item.TypeParameter);
            if (item.ConstraintClause != null)
            {
                constraintClauses.Add(item.ConstraintClause);
            }
        }

        public void Clear()
        {
            typeParameters.Clear();
            constraintClauses.Clear();
        }

        public bool Contains(GenericParameterDeclarationSyntax item)
        {
            return typeParameters.Contains(item.TypeParameter) &&
                (item.ConstraintClause == null || constraintClauses.Contains(item.ConstraintClause));
        }

        public void CopyTo(GenericParameterDeclarationSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public bool Remove(GenericParameterDeclarationSyntax item)
        {
            return typeParameters.Remove(item.TypeParameter) &&
                (item.ConstraintClause == null || constraintClauses.Remove(item.ConstraintClause));
        }

        public IEnumerator<GenericParameterDeclarationSyntax> GetEnumerator()
        {
            return typeParameters.Select(GetSyntax).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private GenericParameterDeclarationSyntax GetSyntax(TypeParameterSyntax syntax)
        {
            return new GenericParameterDeclarationSyntax(syntax, GetConstraintClause(syntax));
        }

        private TypeParameterConstraintClauseSyntax GetConstraintClause(TypeParameterSyntax syntax)
        {
            string text = syntax.Identifier.Text;
            return constraintClauses.FirstOrDefault(clause => clause.Name.Identifier.Text == text);
        }

        private int? GetConstraintClauseIndex(TypeParameterSyntax syntax)
        {
            string text = syntax.Identifier.Text;
            int index = 0;
            foreach (TypeParameterConstraintClauseSyntax constraintClause in constraintClauses)
            {
                if (constraintClause.Name.Identifier.Text == text)
                {
                    return index;
                }

                index++;
            }

            return null;
        }

        public TParentSyntax Set(int index, GenericParameterDeclarationSyntax value)
        {
            if (this[index] == value)
            {
                return node.Syntax;
            }

            this[index] = value;
            return node.Syntax;
        }
    }
}
