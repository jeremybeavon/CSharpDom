using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedClassWithLinqExpressions : IClassWithSymbol, ITypeWithLinqExpressions, IHasType,
        IHasDeclarations<INestedClassDeclarationWithLinqExpressions>,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasDestructor<INestedDestructorWithLinqExpressions>,
        IHasSyntax<INestedClassSyntax>,
        IHasSymbols<INestedClassWithSymbols>,
        IHasReflection<INestedClassWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
