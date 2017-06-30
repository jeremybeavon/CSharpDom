using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class TypeSyntaxExtensions
    {
        private static readonly IDictionary<Type, Type> correspondingTypes =
            new Dictionary<Type, Type>()
            {
                { typeof(ArrayTypeSyntax), typeof(ArrayTypeReferenceWithCodeAnalysis) },
                { typeof(GenericNameSyntax), typeof(UnspecifiedTypeReferenceWithCodeAnalysis) },
                { typeof(IdentifierNameSyntax), typeof(UnspecifiedTypeReferenceWithCodeAnalysis) },
                { typeof(PredefinedTypeSyntax), typeof(BuiltInTypeReferenceWithCodeAnalysis) }
            };

        public static IInternalTypeReferenceWithCodeAnalysis ToTypeReference(this TypeSyntax syntax)
        {
            if (syntax is SimpleNameSyntax name)
            {
                return new UnspecifiedTypeReferenceWithCodeAnalysis();
            }

            if (syntax is PredefinedTypeSyntax builtInType)
            {
                return new BuiltInTypeReferenceWithCodeAnalysis();
            }

            if (syntax is ArrayTypeSyntax array)
            {
                return new ArrayTypeReferenceWithCodeAnalysis();
            }

            //NullableTypeSyntax nullableType = syntax as NullableTypeSyntax;
            //if (nullableType != null)
            //{
            //    return null;
            //}

            throw new NotSupportedException();
        }

        public static ITypeReferenceWithCodeAnalysis ToTypeReference(this PropertyWithBodyWithCodeAnalysis parent)
        {
            return null;
        }

        public static NameSyntax ToName(this TypeSyntax syntax)
        {
            return null;
        }
    }
}
