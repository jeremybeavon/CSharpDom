using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStaticClassNestedStructWrapper :
        IStaticClassNestedStruct<
            IAttributeGroupWrapper,
            IStaticTypeWrapper,
            IGenericParameterDeclarationWrapper,
            IInterfaceReferenceWrapper,
            IStructEventCollectionWrapper,
            IStructPropertyCollectionWrapper,
            IStructIndexerCollectionWrapper,
            IStructMethodCollectionWrapper,
            IStructFieldCollectionWrapper,
            IStructConstructorWrapper,
            IOperatorOverloadWrapper,
            IConversionOperatorWrapper,
            IStructNestedClassCollectionWrapper,
            IStructNestedDelegateWrapper,
            IStructNestedEnumWrapper,
            IStructNestedInterfaceCollectionWrapper,
            IStructNestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
