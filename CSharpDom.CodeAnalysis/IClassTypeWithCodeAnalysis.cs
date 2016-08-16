using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis
{
    public interface IClassTypeWithCodeAnalysis :
        IType<
            ClassEventCollectionWithCodeAnalysis,
            ClassPropertyCollectionWithCodeAnalysis,
            ClassIndexerCollectionWithCodeAnalysis,
            ClassMethodCollectionWithCodeAnalysis,
            ClassFieldCollectionWithCodeAnalysis,
            ClassConstructorWithCodeAnalysis,
            OperatorOverloadWithCodeAnalysis,
            ConversionOperatorWithCodeAnalysis,
            ClassNestedClassCollectionWithCodeAnalysis,
            ClassNestedDelegateWithCodeAnalysis,
            ClassNestedEnumWithCodeAnalysis,
            ClassNestedInterfaceCollectionWithCodeAnalysis,
            ClassNestedStructCollectionWithCodeAnalysis,
            StaticConstructorWithCodeAnalysis>,
        IClassType,
        IHasAttributes<AttributeGroupWithCodeAnalysis>,
        IHasGenericParameters<GenericParameterDeclarationWithCodeAnalysis>,
        IHasImplementedInterfaces<InterfaceReferenceWithCodeAnalysis>
    {
    }
}
