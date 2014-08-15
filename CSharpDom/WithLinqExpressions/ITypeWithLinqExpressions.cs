using CSharpDom.Common;

namespace CSharpDom.WithLinqExpressions
{
    public interface ITypeWithLinqExpressions : IBasicTypeWithLinqExpressions,
        IHasFields<IFieldWithLinqExpressions>,
        IHasConstructors<IConstructorWithLinqExpressions>,
        IHasEventProperties<IEventPropertyWithLinqExpressions>,
        IHasOperatorOverloads<IOperatorOverloadWithLinqExpressions>,
        IHasConversionOperators<IConversionOperatorWithLinqExpressions>,
        IHasClasses<INestedClassWithLinqExpressions>,
        IHasDelegates<INestedDelegateWithLinqExpressions>,
        IHasEnums<INestedEnumWithLinqExpressions>,
        IHasInterfaces<INestedInterfaceWithLinqExpressions>,
        IHasStructs<INestedStructWithLinqExpressions>
    {
    }
}
