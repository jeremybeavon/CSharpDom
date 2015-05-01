using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedInterfaceWithLinqExpressions : IInterfaceWithSymbol, IHasType, IBasicTypeWithLinqExpressions,
        IHasDeclarations<INestedInterfaceDeclarationWithLinqExpressions>,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasSyntax<INestedInterfaceSyntax>,
        IHasSymbols<INestedInterfaceWithSymbols>,
        IHasReflection<INestedInterfaceWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
