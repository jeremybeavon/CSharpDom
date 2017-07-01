using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface IClassTypeWithReflection :
        IType<
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
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
            ClassNestedInterfaceWithReflection,
            ClassNestedStructCollectionWithReflection,
            StaticConstructorWithReflection>,
        IClassType,
        IHasAttributes<AttributeWithReflection>,
        IHasGenericParameters<GenericParameterDeclarationWithReflection>,
        IHasImplementedInterfaces<InterfaceReferenceWithReflection>
    {
    }
}
