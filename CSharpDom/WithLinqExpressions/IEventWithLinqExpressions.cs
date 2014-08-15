using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IEventWithLinqExpressions : IEventWithSymbol, IHasEventInfo,
        IHasDeclaringType<IBasicTypeWithLinqExpressions>,
        IHasSyntax<IEventSyntax>,
        IHasSymbols<IEventWithSymbols>,
        IHasReflection<IEventWithReflection>
    {
    }
}
