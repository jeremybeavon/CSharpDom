using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IDestructorWithLinqExpressions : IDestructorWithSymbol, IHasMethodInfo,
        IHasDeclaringType<IClassWithLinqExpressions>,
        IHasSyntax<IDestructorSyntax>,
        IHasSymbols<IDestructorWithSymbols>,
        IHasReflection<IDestructorWithReflection>
    {
    }
}
