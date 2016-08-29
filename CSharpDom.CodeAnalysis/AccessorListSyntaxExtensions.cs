using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class AccessorListSyntaxExtensions
    {
        internal static AccessorDeclarationSyntax GetAccessorDeclaration(this AccessorListSyntax syntax, SyntaxKind kind)
        {
            return syntax.Accessors.FirstOrDefault(accessor => accessor.Keyword.Kind() == kind);
        }

        internal static AccessorListSyntax WithAccessor(
            this AccessorListSyntax parentSyntax,
            AccessorDeclarationSyntax childSyntax,
            SyntaxKind kind)
        {
            AccessorDeclarationSyntax oldChildSyntax = GetAccessorDeclaration(parentSyntax, kind);
            SyntaxList<AccessorDeclarationSyntax>? newList = null;
            if (childSyntax == null)
            {
                if (childSyntax != null)
                {
                    newList = parentSyntax.Accessors.Remove(oldChildSyntax);
                }
            }
            else if (childSyntax == null)
            {
                newList = parentSyntax.Accessors.Add(childSyntax);
            }
            else
            {
                newList = parentSyntax.Accessors.Replace(oldChildSyntax, childSyntax);
            }

            if (newList != null)
            {
                parentSyntax = parentSyntax.WithAccessors(newList.Value);
            }

            return parentSyntax;
        }
    }
}
