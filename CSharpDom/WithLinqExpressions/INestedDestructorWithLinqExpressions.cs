using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedDestructorWithLinqExpressions : IDestructor,
        IHasDeclaringType<INestedClassDeclarationWithLinqExpressions>,
        IHasSymbol<IMethodSymbol>,
        IHasSyntax<INestedDestructorSyntax>,
        IHasSymbols<INestedDestructorWithSymbols>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
