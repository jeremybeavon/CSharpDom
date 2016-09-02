using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ISealedTypeWrapper :
        ISealedType<
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            ISealedClassEventCollectionWrapper,
            ISealedClassPropertyCollectionWrapper,
            ISealedClassIndexerCollectionWrapper,
            ISealedClassMethodCollectionWrapper,
            IClassFieldCollectionWrapper,
            IClassConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            IClassNestedClassCollectionWrapper,
            IClassNestedDelegateWrapper,
            IClassNestedEnumWrapper,
            IClassNestedInterfaceCollectionWrapper,
            IClassNestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
