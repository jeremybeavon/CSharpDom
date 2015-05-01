using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IConstructorWithLinqExpressions : IConstructorWithSymbol, IHasConstructorInfo,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<IConstructorSyntax>,
        IHasSymbols<IConstructorWithSymbols>,
        IHasReflection<IConstructorWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
