using CSharpDom.Common;

namespace CSharpDom.WithSymbols
{
    public interface ITypeWithSymbols : IBasicTypeWithSymbols,
        IHasFields<IFieldWithSymbols>,
        IHasConstructors<IConstructorWithSymbols>,
        IHasEventProperties<IEventPropertyWithSymbols>,
        IHasOperatorOverloads<IOperatorOverloadWithSymbols>,
        IHasConversionOperators<IConversionOperatorWithSymbols>,
        IHasClasses<INestedClassWithSymbols>,
        IHasDelegates<INestedDelegateWithSymbols>,
        IHasEnums<INestedEnumWithSymbols>,
        IHasInterfaces<INestedInterfaceWithSymbols>,
        IHasStructs<INestedStructWithSymbols>
    {
    }
}
