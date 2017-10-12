using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class GenericParameterDeclarationList<TParentNode, TParentSyntax> : IList<GenericParameterDeclarationSyntax>
        where TParentSyntax : class
    {
        private readonly IList<TypeParameterSyntax> typeParameters;
        private readonly IList<TypeParameterConstraintClauseSyntax> constraintClauses;

        public GenericParameterDeclarationList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>> getTypeParameters,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
        {
            typeParameters = ListFactory.CreateList(node, getTypeParameters, createTypeParameters);
            constraintClauses = ListFactory.CreateList(node, getConstraintClauses, createConstraintClauses);
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
                typeParameters[index] = value.TypeParameter;
                if (value.ConstraintClause != null)
                {
                    constraintClauses[index] = value.ConstraintClause;
                }
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
            constraintClauses.Remove(GetConstraintClause(typeParameters[index]));
            typeParameters.RemoveAt(index);
        }

        public void Add(GenericParameterDeclarationSyntax item)
        {
            typeParameters.Add(item.TypeParameter);
            constraintClauses.Add(item.ConstraintClause);
        }

        public void Clear()
        {
            typeParameters.Clear();
            constraintClauses.Clear();
        }

        public bool Contains(GenericParameterDeclarationSyntax item)
        {
            return typeParameters.Contains(item.TypeParameter) && constraintClauses.Contains(item.ConstraintClause);
        }

        public void CopyTo(GenericParameterDeclarationSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public bool Remove(GenericParameterDeclarationSyntax item)
        {
            return typeParameters.Remove(item.TypeParameter) && constraintClauses.Remove(item.ConstraintClause);
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
    }
}
