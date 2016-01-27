using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IStructWithSymbols :
        IStruct<INamespaceWithSymbols, IProjectWithSymbols, ISolutionWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols, IFieldWithSymbols, IConstructorWithSymbols, IEventPropertyWithSymbols, IOperatorOverloadWithSymbols, IConversionOperatorWithSymbols, INestedClassWithSymbols, INestedDelegateWithSymbols, INestedEnumWithSymbols, INestedInterfaceWithSymbols, INestedStructWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        ITypeWithSymbols,
        IHasSyntax<IStructSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
