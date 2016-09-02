﻿using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IAbstractTypeWrapper :
        IAbstractType<
            IAttributeGroupWrapper,
            IGenericParameterDeclarationWrapper,
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
            IClassNestedInterfaceCollectionWrapper,
            IClassNestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
