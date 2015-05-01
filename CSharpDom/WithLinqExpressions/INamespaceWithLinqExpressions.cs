using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INamespaceWithLinqExpressions : INamespace,
        IHasClasses<IClassWithLinqExpressions>,
        IHasDelegates<IDelegateWithLinqExpressions>,
        IHasEnums<IEnumWithLinqExpressions>,
        IHasInterfaces<IInterfaceWithLinqExpressions>,
        IHasStructs<IStructWithLinqExpressions>,
        IHasSyntax<INamespaceSyntax>,
        IHasSymbols<INamespaceWithSymbols>,
        IHasReflection<INamespaceWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
