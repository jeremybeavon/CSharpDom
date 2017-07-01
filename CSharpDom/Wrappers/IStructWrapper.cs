using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IStructWrapper :
        IStruct<
            INamespaceWrapper,
            IDocumentWrapper,
            IProjectWrapper,
            ISolutionWrapper,
            IAttributeGroupWrapper,
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
