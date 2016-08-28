using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class EventDeclarationSyntaxExtensions
    {
        public static AccessorDeclarationSyntax GetAccessor(this EventDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.Accessors.FirstOrDefault(accessor => accessor.Keyword.Kind() == kind);
        }

        public static EventDeclarationSyntax WithAccessor(
            this EventDeclarationSyntax syntax,
            SyntaxKind kind,
            AccessorDeclarationSyntax accessor)
        {
            AccessorListSyntax accessorList = syntax.AccessorList;
            return syntax.WithAccessorList(
                accessorList.WithAccessors(accessorList.Accessors.Replace(GetAccessor(syntax, kind), accessor)));
        }

        public static EventDeclarationSyntax WithBody(
            this EventDeclarationSyntax parentSyntax,
            BlockSyntax childSyntax,
            SyntaxKind kind)
        {
            return parentSyntax.WithAccessor(kind, parentSyntax.GetAccessor(kind).WithBody(childSyntax));
        }
    }
}
