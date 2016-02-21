using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface IClassTypeWithReflection :
        IType<
            ClassEventCollectionWithReflection,
            ClassPropertyCollectionWithReflection,
            ClassIndexerCollectionWithReflection,
            ClassMethodCollectionWithReflection,
            ClassFieldCollectionWithReflection,
            ClassConstructorWithReflection,
            OperatorOverloadWithReflection,
            ConversionOperatorWithReflection,
            ClassNestedClassCollectionWithReflection,
            ClassNestedDelegateWithReflection,
            ClassNestedEnumWithReflection,
            ClassNestedInterfaceCollectionWithReflection,
            ClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>,
        IClassType,
        IHasAttributes<AttributeWithReflection>,
        IHasGenericParameters<GenericParameterDeclarationWithReflection>,
        IHasImplementedInterfaces<InterfaceReferenceWithReflection>
    {
    }
}
