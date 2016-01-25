using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface ITypeWithReflection : 
        IType<
            EventWithReflection,
            PropertyWithReflection,
            IndexerWithReflection,
            MethodWithReflection,
            FieldWithReflection,
            ConstructorWithReflection,
            EventPropertyWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            NestedClassWithReflection,
            NestedDelegateWithReflection,
            NestedEnumWithReflection,
            NestedInterfaceWithReflection,
            NestedStructWithReflection>,
        IBasicTypeWithReflection
    {
    }
}
