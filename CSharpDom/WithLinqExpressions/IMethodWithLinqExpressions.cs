using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IMethodWithLinqExpressions : IMethodWithSymbol, IHasMethodInfo,
        IHasDeclaringType<IBasicTypeWithLinqExpressions>,
        IHasSyntax<IMethodSyntax>,
        IHasSymbols<IMethodWithSymbols>,
        IHasReflection<IMethodWithReflection>
    {
        IImplementation Implementation { get; }

        void Accept(ILinqExpressionsVisitor visitor);
    }
}
