using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IPropertySyntax : IProperty<IBasicTypeSyntax>, IHasDeclaration<PropertyDeclarationSyntax>, IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
