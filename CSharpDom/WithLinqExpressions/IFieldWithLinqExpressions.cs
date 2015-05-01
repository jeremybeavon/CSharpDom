using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface IFieldWithLinqExpressions : IFieldWithSymbol, IHasFieldInfo,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<IFieldSyntax>,
        IHasSymbols<IFieldWithSymbols>,
        IHasReflection<IFieldWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
