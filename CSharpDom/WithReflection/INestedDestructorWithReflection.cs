using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public interface INestedDestructorWithReflection : IDestructor,
        IHasDeclaringType<INestedClassDeclarationWithReflection>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<INestedDestructorSyntax>,
        IHasSymbols<INestedDestructorWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
