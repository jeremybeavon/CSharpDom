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
    internal static class NameSyntaxExtensions
    {
        public static string ToName(this NameSyntax syntax)
        {
            IdentifierNameSyntax identifier = syntax as IdentifierNameSyntax;
            if (identifier != null)
            {
                return identifier.Identifier.Text;
            }

            GenericNameSyntax generic = syntax as GenericNameSyntax;
            if (generic != null)
            {
                return generic.Identifier.Text;
            }

            QualifiedNameSyntax qualifiedName = syntax as QualifiedNameSyntax;
            if (qualifiedName != null)
            {
                return qualifiedName.Right.ToName();
            }

            AliasQualifiedNameSyntax alias = syntax as AliasQualifiedNameSyntax;
            if (alias != null)
            {
                return alias.Name.ToName();
            }

            throw new NotSupportedException("Unknown class");
        }

        public static SeparatedSyntaxList<TypeSyntax> GetGenericParameters(this NameSyntax syntax)
        {
            IdentifierNameSyntax identifier = syntax as IdentifierNameSyntax;
            if (identifier != null)
            {
                return SyntaxFactory.SeparatedList<TypeSyntax>();
            }

            GenericNameSyntax generic = syntax as GenericNameSyntax;
            if (generic != null)
            {
                return generic.TypeArgumentList.Arguments;
            }

            QualifiedNameSyntax qualifiedName = syntax as QualifiedNameSyntax;
            if (qualifiedName != null)
            {
                return GetGenericParameters(qualifiedName.Right);
            }

            AliasQualifiedNameSyntax alias = syntax as AliasQualifiedNameSyntax;
            if (alias != null)
            {
                return GetGenericParameters(alias.Name);
            }

            throw new NotSupportedException("Unknown class");
        }

        public static NameSyntax SetGenericParameters(this NameSyntax syntax, SeparatedSyntaxList<TypeSyntax> genericParameters)
        {
            IdentifierNameSyntax identifier = syntax as IdentifierNameSyntax;
            if (identifier != null)
            {
                return SyntaxFactory.GenericName(identifier.Identifier, SyntaxFactory.TypeArgumentList(genericParameters));
            }

            GenericNameSyntax generic = syntax as GenericNameSyntax;
            if (generic != null)
            {
                return generic.WithTypeArgumentList(generic.TypeArgumentList.WithArguments(genericParameters));
            }

            QualifiedNameSyntax qualifiedName = syntax as QualifiedNameSyntax;
            if (qualifiedName != null)
            {
                return qualifiedName.WithRight((SimpleNameSyntax)SetGenericParameters(qualifiedName.Right, genericParameters));
            }

            AliasQualifiedNameSyntax alias = syntax as AliasQualifiedNameSyntax;
            if (alias != null)
            {
                return alias.WithName((SimpleNameSyntax)SetGenericParameters(alias.Name, genericParameters));
            }

            throw new NotSupportedException("Unknown class");
        }
    }
}
