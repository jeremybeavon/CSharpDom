using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IFieldSyntax :
        IField<ITypeSyntax>,
        IHasDeclaration<FieldDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
