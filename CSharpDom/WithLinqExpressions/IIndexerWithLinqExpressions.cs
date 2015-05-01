using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IIndexerWithLinqExpressions : IIndexerWithSymbol, IHasPropertyInfo,
        IHasDeclaringType<IBasicTypeWithLinqExpressions>,
        IHasSyntax<IIndexerSyntax>,
        IHasSymbols<IIndexerWithSymbols>,
        IHasReflection<IIndexerWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
