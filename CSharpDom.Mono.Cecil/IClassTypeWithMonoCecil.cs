using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public interface IClassTypeWithMonoCecil :
        IType<
            AttributeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            ClassEventCollectionWithMonoCecil,
            ClassPropertyCollectionWithMonoCecil,
            ClassIndexerCollectionWithMonoCecil,
            ClassMethodCollectionWithMonoCecil,
            ClassFieldCollectionWithMonoCecil,
            ClassConstructorWithMonoCecil,
            OperatorOverloadWithMonoCecil,
            ConversionOperatorWithMonoCecil,
            ClassNestedClassCollectionWithMonoCecil,
            ClassNestedDelegateWithMonoCecil,
            ClassNestedEnumWithMonoCecil,
            ClassNestedInterfaceWithMonoCecil,
            ClassNestedStructCollectionWithMonoCecil,
            StaticConstructorWithMonoCecil>,
        IClassType,
        IHasAttributes<AttributeWithMonoCecil>,
        IHasGenericParameters<GenericParameterDeclarationWithMonoCecil>,
        IHasImplementedInterfaces<InterfaceReferenceWithMonoCecil>
    {
    }
}
