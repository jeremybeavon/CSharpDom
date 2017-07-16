using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IAbstractTypeWrapper :
        IAbstractType<
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IClassReferenceWrapper,
            IInterfaceReferenceWrapper,
            IAbstractClassEventCollectionWrapper,
            IAbstractClassPropertyCollectionWrapper,
            IAbstractClassIndexerCollectionWrapper,
            IAbstractClassMethodCollectionWrapper,
            IClassFieldCollectionWrapper,
            IClassConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            IClassNestedClassCollectionWrapper,
            IClassNestedDelegateWrapper,
            IClassNestedEnumWrapper,
            IClassNestedInterfaceWrapper,
            IClassNestedStructCollectionWrapper,
            IStaticConstructorWrapper,
            IDestructorWrapper>
    {
    }
}
