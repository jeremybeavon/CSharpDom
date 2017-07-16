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
            if (syntax is IdentifierNameSyntax identifier)
            {
                return identifier.Identifier.Text;
            }

            if (syntax is GenericNameSyntax generic)
            {
                return generic.Identifier.Text;
            }

            if (syntax is QualifiedNameSyntax qualifiedName)
            {
                return qualifiedName.Right.ToName();
            }

            if (syntax is AliasQualifiedNameSyntax alias)
            {
                return alias.Name.ToName();
            }

            throw new NotSupportedException("Unknown class");
        }

        public static NameSyntax WithName(this NameSyntax syntax, string name)
        {
            return syntax;
        }

        public static SeparatedSyntaxList<TypeSyntax> ToGenericParameters(this NameSyntax syntax)
        {
            if (syntax is IdentifierNameSyntax identifier)
            {
                return SyntaxFactory.SeparatedList<TypeSyntax>();
            }

            if (syntax is GenericNameSyntax generic)
            {
                return generic.TypeArgumentList.Arguments;
            }

            if (syntax is QualifiedNameSyntax qualifiedName)
            {
                return ToGenericParameters(qualifiedName.Right);
            }

            if (syntax is AliasQualifiedNameSyntax alias)
            {
                return ToGenericParameters(alias.Name);
            }

            throw new NotSupportedException("Unknown class");
        }
        
        public static NameSyntax WithGenericParameters(this NameSyntax syntax, SeparatedSyntaxList<TypeSyntax> genericParameters)
        {
            if (syntax is IdentifierNameSyntax identifier)
            {
                return SyntaxFactory.GenericName(identifier.Identifier, SyntaxFactory.TypeArgumentList(genericParameters));
            }

            if (syntax is GenericNameSyntax generic)
            {
                return generic.WithTypeArgumentList(generic.TypeArgumentList.WithArguments(genericParameters));
            }

            if (syntax is QualifiedNameSyntax qualifiedName)
            {
                return qualifiedName.WithRight((SimpleNameSyntax)WithGenericParameters(qualifiedName.Right, genericParameters));
            }

            if (syntax is AliasQualifiedNameSyntax alias)
            {
                return alias.WithName((SimpleNameSyntax)WithGenericParameters(alias.Name, genericParameters));
            }

            throw new NotSupportedException("Unknown class");
        }
    }
}
