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
            //SimpleNameSyntax name = syntax as SimpleNameSyntax;
            //if (name != null)
            //{
            //    return new UnspecifiedTypeReferenceWithCodeAnalysis((AttributeWithCodeAnalysis)null);
            //}

            //PredefinedTypeSyntax builtInType = syntax as PredefinedTypeSyntax;
            //if (builtInType != null)
            //{
            //    return new BuiltInTypeReferenceWithCodeAnalysis();
            //}

            //ArrayTypeSyntax array = syntax as ArrayTypeSyntax;
            //if (array != null)
            //{
            //    return new ArrayTypeReferenceWithCodeAnalysis(null);
            //}

            //NullableTypeSyntax nullableType = syntax as NullableTypeSyntax;
            //if (nullableType != null)
            //{
            //    return null;
            //}

            return null;
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
