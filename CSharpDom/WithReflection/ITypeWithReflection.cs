using CSharpDom.Common;

namespace CSharpDom.WithReflection
{
    public interface ITypeWithReflection : IBasicTypeWithReflection,
        IHasFields<IFieldWithReflection>,
        IHasConstructors<IConstructorWithReflection>,
        IHasEventProperties<IEventPropertyWithReflection>,
        IHasOperatorOverloads<IOperatorOverloadWithReflection>,
        IHasConversionOperators<IConversionOperatorWithReflection>,
        IHasClasses<INestedClassWithReflection>,
        IHasDelegates<INestedDelegateWithReflection>,
        IHasEnums<INestedEnumWithReflection>,
        IHasInterfaces<INestedInterfaceWithReflection>,
        IHasStructs<INestedStructWithReflection>
    {
    }
}
