using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface ITypeWithSymbols :
        IType<IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols, IFieldWithSymbols, IConstructorWithSymbols, IEventPropertyWithSymbols, IOperatorOverloadWithSymbols, IConversionOperatorWithSymbols, INestedClassWithSymbols, INestedDelegateWithSymbols, INestedEnumWithSymbols, INestedInterfaceWithSymbols, INestedStructWithSymbols>,
        IBasicTypeWithSymbols
    {
    }
}
