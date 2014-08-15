using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithReflection
{
    public interface IEventWithReflection : IEventWithSymbol, IHasEventInfo,
        IHasDeclaringType<IBasicTypeWithReflection>,
        IHasSyntax<IEventSyntax>,
        IHasSymbols<IEventWithSymbols>
    {
        void Accept(IReflectionVisitor visitor);
    }
}
