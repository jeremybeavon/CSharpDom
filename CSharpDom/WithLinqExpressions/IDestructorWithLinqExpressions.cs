using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IDestructorWithLinqExpressions : IDestructorWithSymbol, IHasMethodInfo,
        IHasDeclaringType<IClassDeclarationWithLinqExpressions>,
        IHasSyntax<IDestructorSyntax>,
        IHasSymbols<IDestructorWithSymbols>,
        IHasReflection<IDestructorWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
