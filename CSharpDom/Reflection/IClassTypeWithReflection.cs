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
        IHasAttributes<AttributeWithReflection>,
        IHasGenericParameters<GenericParameterDeclarationWithReflection>,
        IHasImplementedInterfaces<InterfaceReferenceWithReflection>
    {
    }
}
