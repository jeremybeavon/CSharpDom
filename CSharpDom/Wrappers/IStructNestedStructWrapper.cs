using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructNestedStructWrapper :
        IStructNestedStruct<
            IAttributeGroupWrapper,
            IStructTypeWrapper,
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
            IStructNestedInterfaceWrapper,
            IStructNestedStructCollectionWrapper,
            IStaticConstructorWrapper>
    {
    }
}
