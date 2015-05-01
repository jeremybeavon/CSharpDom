using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithSymbols;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public interface INestedInterfaceDeclarationWithLinqExpressions : IInterface, IBasicTypeWithLinqExpressions,
        IHasDeclaration<InterfaceDeclarationSyntax>,
        IHasDeclaringType<ITypeWithLinqExpressions>,
        IHasCompositeType<INestedInterfaceWithLinqExpressions>,
        IHasSyntax<INestedInterfaceDeclarationSyntax>,
        IHasSymbols<INestedInterfaceDeclarationWithSymbols>,
        IHasReflection<INestedInterfaceDeclarationWithReflection>
    {
        void Accept(ILinqExpressionsVisitor visitor);
    }
}
