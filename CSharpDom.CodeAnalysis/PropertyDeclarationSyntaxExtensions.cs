using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal static class PropertyDeclarationSyntaxExtensions
    {
        public static bool IsAutoProperty(this PropertyDeclarationSyntax syntax)
        {
            if (syntax.ExplicitInterfaceSpecifier != null)
            {
                return false;
            }

            AccessorDeclarationSyntax accessor = syntax?.AccessorList?.Accessors.FirstOrDefault();
            return accessor != null && accessor.Body == null;
        }

        public static bool IsLambdaProperty(this PropertyDeclarationSyntax syntax)
        {
            return syntax.ExplicitInterfaceSpecifier == null && syntax.ExpressionBody != null;
        }

        public static bool IsExplicitInterfaceProperty(this PropertyDeclarationSyntax syntax)
        {
            return syntax.ExplicitInterfaceSpecifier != null;
        }

        public static bool IsProperty(this PropertyDeclarationSyntax syntax)
        {
            return !syntax.IsAutoProperty() && !syntax.IsLambdaProperty() && !syntax.IsExplicitInterfaceProperty();
        }
    }
}
