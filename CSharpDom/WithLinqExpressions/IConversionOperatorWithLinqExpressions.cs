using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IConversionOperatorWithLinqExpressions : IConversionOperatorWithSymbol, IHasMethodInfo,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<IConversionOperatorSyntax>,
        IHasSymbols<IConversionOperatorWithSymbols>,
        IHasReflection<IConversionOperatorWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
