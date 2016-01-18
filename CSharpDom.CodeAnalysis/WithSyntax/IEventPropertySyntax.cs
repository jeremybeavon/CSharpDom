using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IEventPropertySyntax :
        IEventProperty<ITypeSyntax>,
        IHasDeclaration<EventDeclarationSyntax>,
        IHasLocation
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
