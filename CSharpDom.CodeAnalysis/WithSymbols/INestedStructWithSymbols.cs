using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface INestedStructWithSymbols :
        INestedStruct<ITypeWithSymbols, IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols, IFieldWithSymbols, IConstructorWithSymbols, IEventPropertyWithSymbols, IOperatorOverloadWithSymbols, IConversionOperatorWithSymbols, INestedClassWithSymbols, INestedDelegateWithSymbols, INestedEnumWithSymbols, INestedInterfaceWithSymbols, INestedStructWithSymbols>,
        IHasSymbol<INamedTypeSymbol>,
        ITypeWithSymbols,
        IHasDeclaringType<ITypeWithSymbols>,
        IHasSyntax<INestedStructSyntax>
    {
        void Accept(ISymbolsVisitor visitor);
    }
}
