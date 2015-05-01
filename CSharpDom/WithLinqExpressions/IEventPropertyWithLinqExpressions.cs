using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IEventPropertyWithLinqExpressions : IEventPropertyWithSymbol, IHasEventInfo,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<IEventPropertySyntax>,
        IHasSymbols<IEventPropertyWithSymbols>,
        IHasReflection<IEventPropertyWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
