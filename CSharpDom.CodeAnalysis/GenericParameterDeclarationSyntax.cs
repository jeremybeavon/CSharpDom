using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterDeclarationSyntax
    {
        public GenericParameterDeclarationSyntax(
            TypeParameterSyntax typeParameter,
            TypeParameterConstraintClauseSyntax constraintClause)
        {
            TypeParameter = typeParameter;
            ConstraintClause = constraintClause;
        }

        public TypeParameterConstraintClauseSyntax ConstraintClause { get; private set; }

        public SeparatedSyntaxList<TypeParameterConstraintSyntax> Constraints
        {
            get { return ConstraintClause.Constraints; }
        }

        public TypeParameterSyntax TypeParameter { get; private set; }

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
    }
}
