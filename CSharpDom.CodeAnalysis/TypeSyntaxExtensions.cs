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
        /*public static ChildReference<TParent, ITypeReferenceWithCodeAnalysis> ToChildReference<TParent>(
            this TypeSyntax syntax,
            ChildReference<TParent, ITypeReferenceWithCodeAnalysis> currentReference)
            where TParent : class
        {
            return ToChildReference(syntax as ArrayTypeSyntax, currentReference) ??
                currentReference;
        }

        public static ChildReference<TParent, ITypeReferenceWithCodeAnalysis> ToChildReference<TParent>(
            ArrayTypeSyntax syntax,
            ChildReference<TParent, ITypeReferenceWithCodeAnalysis> currentReference)
            where TParent : class
        {
            if (syntax == null)
            {
                return null;
            }

            if (!(currentReference.Child is ArrayTypeReferenceWithCodeAnalysis))
            {
                currentReference.SetParent(null);

                ArrayTypeReferenceWithCodeAnalysis type = new ArrayTypeReferenceWithCodeAnalysis()
            }

            return currentReference;
        }*/
    }
}
