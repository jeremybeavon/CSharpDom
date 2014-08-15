using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IOperatorOverloadWithLinqExpressions : IOperatorOverloadWithSymbol, IHasMethodInfo,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<IOperatorOverloadSyntax>, 
        IHasSymbols<IOperatorOverloadWithSymbols>,
        IHasReflection<IOperatorOverloadWithReflection>
    {
    }
}
