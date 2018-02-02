using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterDeclarationSyntax : IEquatable<GenericParameterDeclarationSyntax>
    {
        private readonly TypeParameterSyntax typeParameter;
        private readonly TypeParameterConstraintClauseSyntax constraintClause;

        internal GenericParameterDeclarationSyntax(
            TypeParameterSyntax typeParameter,
            TypeParameterConstraintClauseSyntax constraintClause)
        {
            this.typeParameter = typeParameter;
            this.constraintClause = constraintClause;
        }

        public TypeParameterConstraintClauseSyntax ConstraintClause => constraintClause;

        public SeparatedSyntaxList<TypeParameterConstraintSyntax> Constraints
        {
            get { return ConstraintClause?.Constraints ?? SyntaxFactory.SeparatedList<TypeParameterConstraintSyntax>(); }
        }

        public TypeParameterSyntax TypeParameter => typeParameter;

        public bool Equals(GenericParameterDeclarationSyntax other)
        {
            return other != null && typeParameter == other.typeParameter && constraintClause == other.constraintClause;
        }

        public override int GetHashCode()
        {
            return new Tuple<TypeParameterSyntax, TypeParameterConstraintClauseSyntax>(typeParameter, constraintClause)
                .GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as GenericParameterDeclarationSyntax);
        }

        public GenericParameterDeclarationSyntax WithAttributeLists(SyntaxList<AttributeListSyntax> attributes)
        {
            return new GenericParameterDeclarationSyntax(TypeParameter.WithAttributeLists(attributes), ConstraintClause);
        }

        public GenericParameterDeclarationSyntax WithConstraints(SeparatedSyntaxList<TypeParameterConstraintSyntax> constraints)
        {
            return new GenericParameterDeclarationSyntax(TypeParameter, ConstraintClause.WithConstraints(constraints));
        }

        public GenericParameterDeclarationSyntax WithName(string name)
        {
            return new GenericParameterDeclarationSyntax(
                TypeParameter.WithIdentifier(SyntaxFactory.Identifier(name)),
                ConstraintClause);
        }

        public GenericParameterDeclarationSyntax WithVariance(SyntaxKind kind)
        {
            return new GenericParameterDeclarationSyntax(
                TypeParameter.WithVarianceKeyword(SyntaxFactory.Token(kind)),
                ConstraintClause);
        }

        public override string ToString()
        {
            return typeParameter.ToString() + ";" + constraintClause?.ToString();
        }
    }
}
